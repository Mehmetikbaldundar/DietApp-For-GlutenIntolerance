using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevivalGF.UI.Forms
{
    public partial class NutrientActivity : Form
    {
        public NutrientActivity()
        {
            InitializeComponent();
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void NutrientActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
