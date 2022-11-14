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
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            Forms.MainForm main=new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
