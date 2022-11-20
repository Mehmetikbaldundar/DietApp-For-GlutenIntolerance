using RevivalGF.Business.Services;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Windows.Forms;

namespace RevivalGF.UI.Forms
{
    public partial class Activitytab : Form
    {
        public Activitytab()
        {
            InitializeComponent();
            activityService = new ActivityService();
        }
        ActivityService activityService;
        private void Activity_Load(object sender, EventArgs e)
        {
            cbActivity.DataSource = Enum.GetValues(typeof(Activities));
            activityService.DailyActivities(dataGridView1, Login.userNameControl);            
            activityService.CalorieBurn(lblSportCalorie, Login.userNameControl);
        }

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            try
            {
                Activity newActivity = new Activity()
                {
                    Activities = (Activities)cbActivity.SelectedIndex + 1,
                    ActivityFaktor = Convert.ToDecimal(tbDuration.Text),
                    UserID = Login.userNameControl.UserID,
                };

                bool check=activityService.ActivityAdd(newActivity);
                if (check)
                {
                    activityService.DailyActivities(dataGridView1,Login.userNameControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            activityService.CalorieBurn(lblSportCalorie,Login.userNameControl);
        }

        public int selectedActivityID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedActivityID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ActivityID"].Value);
        }

        private void btnDeleteAct_Click(object sender, EventArgs e)
        {
            try
            {
                activityService.ActivityDelete(selectedActivityID);
                activityService.DailyActivities(dataGridView1, Login.userNameControl);
                activityService.CalorieBurn(lblSportCalorie, Login.userNameControl);
            }
            catch (Exception)
            {

                MessageBox.Show("There isn't any Activity");
            }            
        }

        private void tbDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            NutrientActivity nutrient = new NutrientActivity();
            this.Hide();
            nutrient.Show();
        }

        private void Activitytab_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
