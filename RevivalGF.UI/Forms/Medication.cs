using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
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
    public partial class Medication : Form
    {
        private readonly RevivalGfDbContext db;
        private readonly UserRepository _userRepository;
        private readonly MedicamentRepository _medicamentRepository;
        public Medication()
        {
            db = new RevivalGfDbContext();
            _userRepository = new UserRepository(db);
            _medicamentRepository=new MedicamentRepository(db);
            InitializeComponent();
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            Forms.MainForm main =new MainForm();
            main.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicament medicament= new Medicament()
            { 
                MedicamentName=tbMedicationName.Text,
                HourOfUsage=Convert.ToInt32(nudOneDay.Value),
                TotalUsage=Convert.ToInt32(nudDays.Value),
                UserID=Login.userNameControl.UserID
            };
            _medicamentRepository.Add(medicament);
            ListMedicines();
        }

        private void ListMedicines()
        {          

            dgwMedicines.DataSource = _medicamentRepository.GetAll();
        }

        private void Medication_Load(object sender, EventArgs e)
        {
            ListMedicines();
        }
    }
}
