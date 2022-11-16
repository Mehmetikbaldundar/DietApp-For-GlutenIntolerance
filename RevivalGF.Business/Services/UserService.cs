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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public bool RegisterCheck(User user, UserDetails userDetails, PhysicallyGoal physicallyGoal, BodyAnalysis bodyAnalysis)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(userDetails.Email))
            {
                if (UserNameCheck(user.UserName) == false)
                    throw new Exception("Username cannot be empty !! ");

                if (PasswordCheck(user.Password) == false)
                    throw new Exception("Password cannot be empty !! ");

                EmptyControl(userDetails.Name, userDetails.Surname);
            }
            if (userDetails.BirthDate >= DateTime.Now.Date)
                throw new Exception("Birth Date is not correct !!");

            if (MailCheck(userDetails.Email) == false)
                throw new Exception("Email Address is not correct !!");

            if (PasswordRules(user.Password) == false)
                throw new Exception("Incorrect Password .. \n At least 8 character \n 1 upparcase letter \n 1 lowercase letter \n 1 number \n 1 symbol");

            if (UserNameExist(user.UserName) == true)
                throw new Exception("Username already exists. Please enter a different Username !! ");

            if (MailExist(userDetails.Email) == true)
                throw new Exception("Email already exists. Please enter a different Email !! ");

            if (VerificationCodeSend(userDetails.Email) == false)
                throw new Exception("Verification Code is not Correct !!");

            return UserRegistation(user, userDetails, physicallyGoal, bodyAnalysis);
        }
        private bool UserNameCheck(string username)
        {
            if (username == null || username == "")
                return false;
            else
                return true;
        }
        private bool PasswordCheck(string password)
        {
            if (password == null || password == "")
                return false;
            else
                return true;
        }
        private bool PasswordRules(string password)
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
        private bool UserNameExist(string userName)
        {
            var userNameControl = db.Users.Where(x => x.UserName == userName).FirstOrDefault();
            if (userNameControl != null)
            {
                return true;
            }
            else return false;
        }
        private bool MailExist(string email)
        {
            var emailControl = db.UserDetails.Where(x => x.Email == email).FirstOrDefault();
            if (emailControl != null)
            {
                return true;
            }
            else return false;
        }
        private bool MailCheck(string email)
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
        private bool VerificationCodeSend(string mail)
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
                string verificationControl = Interaction.InputBox("Please Write Verification Code.", "Verification", "", 900, 400);
                if (verificationControl == verificationCode)
                    result = true;
                else
                {
                    result = false;
                }
            }
            catch
            {
                MessageBox.Show("Mail Service Problems. !! ");
            }
            return result;
        }
        private bool UserRegistation(User user, UserDetails userDetails, PhysicallyGoal physicallyGoal, BodyAnalysis bodyAnalysis)
        {
            user.Password = PasswordWithSha256(user.Password);
            _userRepository.Add(user);
            int MainID = user.UserID;
            userDetails.DetailsID = MainID;
            _detailsRepository.Add(userDetails);
            physicallyGoal.GoalID = MainID;
            _goalsRepository.Add(physicallyGoal);
            bodyAnalysis.AnalysisID = MainID;
            _bodyAnalysisRepository.Add(bodyAnalysis);
            MessageBox.Show("Registation Successful");
            return true;
        }
        private int BodyMassIndexCalculator(UserDetails userDetails)
        {
            double height = Convert.ToDouble(userDetails.Height);
            double weight = Convert.ToDouble(userDetails.Weight);
            double heightForMeter = (double)(height / 100);
            return (int)(weight / (heightForMeter * heightForMeter));
        }
        private double BasalMetabolicRate(UserDetails userDetails)
        {
            double height = Convert.ToDouble(userDetails.Height);
            double weight = Convert.ToDouble(userDetails.Weight);
            double age = DateTime.Now.Year - userDetails.BirthDate.Year;
            if (userDetails.Gender == Gender.Man)
                return 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            else
                return 665 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
        }
        private double RestingMetabolicRate(UserDetails userDetails)
        {
            return 1.1 * BasalMetabolicRate(userDetails);
        }
        private decimal ActiveBurn(UserDetails userDetails)
        {
            return (decimal)(1.1 * RestingMetabolicRate(userDetails));
        }
        private decimal ActivityCalculator(PhysicallyGoal physicallyGoal)
        {
            switch (physicallyGoal.ActivityStatus)
            {
                case ActivityStatus.Active:
                    return 1.2M;
                case ActivityStatus.LightlyActive:
                    return 1.375M;
                case ActivityStatus.ModeratelyActive:
                    return 1.55M;
                case ActivityStatus.VeryActive:
                    return 1.9M;
            }
            return 1;
        }
        private decimal TargetedCalorieBurn(PhysicallyGoal physicallyGoal)
        {
            switch (physicallyGoal.TargetedDiet)
            {
                case TargetedDiet.LoseWeight:
                    return -200;
                case TargetedDiet.MaintainWeight:
                    return 0;
                case TargetedDiet.GainWeight:
                    return 200;
            }
            return 0;
        }
        public decimal DailyCalorieCalculator(UserDetails userDetails, PhysicallyGoal physicallyGoal)
        {
            return (ActiveBurn(userDetails) * ActivityCalculator(physicallyGoal)) + TargetedCalorieBurn(physicallyGoal);
        }
        public BodyMassIndex BodyMassIndexResult(UserDetails userDetails)
        {
            if (BodyMassIndexCalculator(userDetails) <= 18)
                return BodyMassIndex.Thin;
            else if (BodyMassIndexCalculator(userDetails) > 18 && BodyMassIndexCalculator(userDetails) <= 24)
                return BodyMassIndex.Normal;
            else if (BodyMassIndexCalculator(userDetails) > 24 && BodyMassIndexCalculator(userDetails) <= 29)
                return BodyMassIndex.OverWeight;
            else if (BodyMassIndexCalculator(userDetails) > 29 && BodyMassIndexCalculator(userDetails) <= 35)
                return BodyMassIndex.FirstDegreeObesity;
            else if (BodyMassIndexCalculator(userDetails) > 35 && BodyMassIndexCalculator(userDetails) <= 45)
                return BodyMassIndex.SecondDegreeObesity;
            else
                return BodyMassIndex.ThirdDegreeObesity;
        }
        public string PasswordWithSha256(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }
        public bool LoginCheck(string username, string password)
        {
            var userNameControl = db.Users.Where(x => x.UserName == username.Trim()).FirstOrDefault();
            if (userNameControl == null)
            {
                MessageBox.Show("User Not Found !!");
                return false;
            }            

            if (userNameControl.Password != PasswordWithSha256(password))
            {
                MessageBox.Show("Password Incorrect! \n Please check and try again");
                return false;
            }               

            return true;
        }
        public User UsernameControl(string username)
        {
            var userNameControl = db.Users.Where(x => x.UserName == username.Trim()).FirstOrDefault();
            if (userNameControl == null)
                MessageBox.Show("Please enter a valid Username or Password. !!");
            return userNameControl;
        }
        private void EmptyControl(string name, string surname)
        {
            if (name == "" || surname == "")
                throw new Exception("Name,Surname and Email cannot be empty !!");
        }

    }
}

