using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace RevivalGF.Business.Services
{
    public class UserService
    {
        private readonly RevivalGfDbContext db;
        private readonly UserRepository _userRepository;
        private readonly UserDetailsRepository _detailsRepository;
        private readonly PhysicallyGoalRepository _goalsRepository;
        private readonly BodyAnalysisRepository _bodyAnalysisRepository;

        public UserService()
        {
            db = new RevivalGfDbContext();
            _userRepository = new UserRepository(db);
            _detailsRepository = new UserDetailsRepository(db);
            _goalsRepository = new PhysicallyGoalRepository(db);
            _bodyAnalysisRepository = new BodyAnalysisRepository(db);
        }

        private void RegisterCheck()
        {
            Login login = new Login();
            if (cbAccepted.Checked)
            {
                if (tbPassword.Text != "" && tbRepeatPassword.Text != "")
                {
                    if (GenaralControl() == true)
                    {
                        if (UserNameExist(tbUsername.Text) == false && MailExist(tbEmail.Text) == false)
                        {
                            if (VerificationCodeSend(tbEmail.Text) == false)
                                MessageBox.Show("Verification Code is not Correct !!");
                            else
                            {
                                User NewUser = new User()
                                {
                                    UserName = tbUsername.Text,
                                    Password = login.PasswordWithSha256(tbPassword.Text),
                                };
                                _userRepository.Add(NewUser);
                                UserDetails NewUserDetails = new UserDetails()
                                {
                                    DetailsID = _userRepository.GetById(NewUser.UserID).UserID,
                                    Email = tbEmail.Text,
                                    Name = tbFirstName.Text.Trim(),
                                    Surname = tbLastName.Text.Trim(),
                                    Gender = rdbWomen.Checked ? Gender.Woman : Gender.Man,
                                    Height = Convert.ToDouble(tbHeight.Text),
                                    Weight = Convert.ToDouble(tbWeight.Text),
                                    BirthDate = Convert.ToDateTime(dtpBirthDate.Value),
                                    GlutenIntolerance = (GlutenIntolerance)cbDisease.SelectedIndex + 1
                                };
                                _detailsRepository.Add(NewUserDetails);

                                PhysicallyGoal physicallyGoal = new PhysicallyGoal()
                                {
                                    GoalID = _userRepository.GetById(NewUser.UserID).UserID,
                                    ActivityStatus = (ActivityStatus)cbActivityLevel.SelectedIndex + 1,
                                    TargetedDiet = (TargetedDiet)cbGoal.SelectedIndex + 1,
                                };
                                _goalsRepository.Add(physicallyGoal);

                                BodyAnalysis bodyAnalysis = new BodyAnalysis()
                                {
                                    AnalysisID = _userRepository.GetById(NewUser.UserID).UserID,
                                    BodyMassIndex = (BodyMassIndex)BodyMassIndexResult(),
                                    DietCalorieControl = DailyCalorieCalculator(),
                                };
                                _bodyAnalysisRepository.Add(bodyAnalysis);

                                MessageBox.Show("Registation Successful");
                            }

                        }
                        else
                            MessageBox.Show("Username or Email already exists. Please enter a different Username or Email !! ");
                    }
                    else
                    {
                        if (UserNameCheck(tbUsername.Text) == false)
                            MessageBox.Show("Username cannot be empty !! ");

                        if (MailCheck(tbEmail.Text) == false)
                            MessageBox.Show("Email Address is not correct");

                        if (PasswordRules(tbPassword.Text) == false)
                            MessageBox.Show("Incorrect Password .. \n Please check to Password Rules");

                        if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                            MessageBox.Show("Passwords do not match");
                    }
                }
                else if (tbUsername.Text == "" && tbPassword.Text == "" && tbRepeatPassword.Text == "" && tbEmail.Text == "")
                {
                    if (UserNameCheck(tbUsername.Text) == false)
                        MessageBox.Show("Username cannot be empty !! ");

                    if (MailCheck(tbEmail.Text) == false)
                        MessageBox.Show("Email Address cannot be empty !! ");

                    if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                        MessageBox.Show("Password cannot be empty !! ");
                }
            }
            else
            {
                MessageBox.Show("Please accept the terms and conditions.\r\n");
            }

        }

        private bool UserNameCheck(string username)
        {
            if (username == null || username == "")
                return false;
            else
                return true;
        }
        private bool PasswordCheck(string password, string retryPassword)
        {
            if (password != retryPassword)
                return false;

            else
                return true;
        }
        public bool PasswordRules(string password)
        {
            int totalCharacter = 0, totalNumberChar = 0, totalUpperChar = 0, totalSpecialChar = 0;
            foreach (var item in password.ToCharArray())
            {
                if (char.IsUpper(item))
                    totalUpperChar++;
                if (char.IsNumber(item))
                    totalNumberChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 8 || totalUpperChar < 1 || totalNumberChar < 1 || totalSpecialChar < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool GenaralControl()
        {
            if (PasswordRules(tbPassword.Text) && PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) && UserNameCheck(tbUsername.Text) && MailCheck(tbEmail.Text))
                return true;

            else
                return false;
        }
        public bool UserNameExist(string userName)
        {
            var userNameControl = db.Users.Where(x => x.UserName == userName).FirstOrDefault();
            if (userNameControl != null)
            {
                return true;
            }
            else return false;
        }
        public bool MailExist(string email)
        {
            var emailControl = db.UserDetails.Where(x => x.Email == email).FirstOrDefault();
            if (emailControl != null)
            {
                return true;
            }
            else return false;
        }
        public bool MailCheck(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static string verificationCode = "";
        public bool VerificationCodeSend(string mail)
        {
            bool result = false;

            string appMail = "revivalgfapp@outlook.com";
            string sifre = "Revivalgf4*";

            Random rnd = new Random();
            string Keys = "0123456789";
            verificationCode = "";
            for (int i = 0; i < 6; i++)
            {
                verificationCode += Keys[rnd.Next(Keys.Length)];
            }
            try
            {
                MailMessage message = new MailMessage(appMail, mail, "Verification Code", "REVIVAL GF Application Registiration Code: '" + verificationCode + "'\n\nRevivalGF Team");
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(appMail, sifre);
                smtp.Send(message);
                string verificationControl = Interaction.InputBox("Please Write Verification Code.", "Verification", "", 0, 0);
                if (verificationControl == verificationCode)
                    result = true;
                else
                {
                    result = false;
                }
            }
            catch
            {
                MessageBox.Show("Mail Address is not correct");
            }
            return result;
        }

        private int BodyMassIndexCalculator()
        {
            double height = Convert.ToDouble(tbHeight.Text);
            double weight = Convert.ToDouble(tbWeight.Text);
            double heightForMeter = (double)(height / 100);
            return (int)(weight / (heightForMeter * heightForMeter));
        }
        private double BasalMetabolicRate()
        {
            double height = Convert.ToDouble(tbHeight.Text);
            double weight = Convert.ToDouble(tbWeight.Text);
            double age = DateTime.Now.Year - dtpBirthDate.Value.Year;
            if (rdbMen.Checked == true)
                return 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            else
                return 665 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
        }
        private double RestingMetabolicRate()
        {
            return 1.1 * BasalMetabolicRate();
        }
        private decimal ActiveBurn()
        {
            return (decimal)(1.1 * RestingMetabolicRate());
        }
        private decimal ActivityCalculator()
        {
            switch (cbActivityLevel.SelectedIndex)
            {
                case 1:
                    return 1.2M;
                case 2:
                    return 1.375M;
                case 3:
                    return 1.55M;
                case 4:
                    return 1.9M;
            }
            return 1;
        }
        private decimal TargetedCalorieBurn()
        {
            switch (cbGoal.SelectedIndex)
            {
                case 1:
                    return -200;
                case 2:
                    return 0;
                case 3:
                    return 200;
            }
            return 0;
        }
        private decimal DailyCalorieCalculator()
        {
            return (ActiveBurn() * ActivityCalculator()) + TargetedCalorieBurn();
        }
        private int BodyMassIndexResult()
        {
            if (BodyMassIndexCalculator() <= 18)
                return (int)BodyMassIndex.Thin;
            else if (BodyMassIndexCalculator() > 18 && BodyMassIndexCalculator() <= 24)
                return (int)BodyMassIndex.Normal;
            else if (BodyMassIndexCalculator() > 24 && BodyMassIndexCalculator() <= 29)
                return (int)BodyMassIndex.OverWeight;
            else if (BodyMassIndexCalculator() > 29 && BodyMassIndexCalculator() <= 35)
                return (int)BodyMassIndex.FirstDegreeObesity;
            else if (BodyMassIndexCalculator() > 35 && BodyMassIndexCalculator() <= 45)
                return (int)BodyMassIndex.SecondDegreeObesity;
            else
                return (int)BodyMassIndex.ThirdDegreeObesity;
        }


    }
}
