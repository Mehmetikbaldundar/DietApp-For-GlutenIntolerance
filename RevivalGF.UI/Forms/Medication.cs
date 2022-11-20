using RevivalGF.Business.Services;
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
        private readonly MedicamentRepository _medicamentRepository;
        public Medication()
        {
            db = new RevivalGfDbContext();            
            _medicamentRepository=new MedicamentRepository(db);
            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;

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
            dgwMedicines.DataSource = db.Medicaments.Select(x => new
            {
                Medicamentname = x.MedicamentName,
                HowManyTimesaDay = x.HourOfUsage,
                ForHowManyDays = x.TotalUsage,
                x.UserID,
                x.MedicamentID,
                x.Status
            }).Where(m => m.UserID == Login.userNameControl.UserID && m.Status == Entites.Enums.Status.Active).ToList();
        }

        private void Medication_Load(object sender, EventArgs e)
        {
            ListMedicines();
            userService.UserTheme(Login.userNameControl, this, Properties.Resources.medicationform, Properties.Resources.Dark_medicationform);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteMedicine = _medicamentRepository.GetById(selectionMedicine);
            deleteMedicine.DeletedDate=DateTime.Now;
            _medicamentRepository.Delete(deleteMedicine);
            dgwMedicines.DataSource = db.Medicaments.Select(x => new
            {    
                Medicamentname = x.MedicamentName,
                HowManyTimesaDay = x.HourOfUsage,
                ForHowManyDays = x.TotalUsage,
                x.UserID,
                x.MedicamentID,
                x.Status
            }).Where(m => m.UserID == Login.userNameControl.UserID && m.Status == Entites.Enums.Status.Active).ToList();
        }
        int selectionMedicine;
        private void dgwMedicines_SelectionChanged(object sender, EventArgs e)
        {
            selectionMedicine = Convert.ToInt32(dgwMedicines.CurrentRow.Cells["MedicamentID"].Value);
        }
    }
}
