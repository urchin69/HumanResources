using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources
{
    public partial class Main : Form
    {
        private delegate void DisplayMessage(string message);//deklaracja delegata w klasie Main

        private HelperAddEdit<List<Workers>> _fileHelper = new HelperAddEdit<List<Workers>>(Program.FilePath);

        private List<Profession> _workersProfession;
        private List<WorkerStatus> _workerStatus;

        public Main()//kontruktor
        {
            InitializeComponent();

            _workersProfession = HelperProfession.GetProfession("Wszystkie");

            _workerStatus= HelperWorkerStatus.GetWorkerStatus("Nieokreślony");

            InitGroupsComboBox();
            RefreshHR();
           
            SetColumnsHeder();

            dgvWorkers.Columns[0].HeaderText = "Numer";




        }


        private void InitGroupsComboBox()
        {
            cmbWorkerStatus.DataSource = _workerStatus;//inicjalizacja ComboBox
            cmbWorkerStatus.DisplayMember = "StatusName";
            cmbWorkerStatus.ValueMember = "Id";

            cmbProfession.DataSource = _workersProfession;//inicjalizacja ComboBox
            cmbProfession.DisplayMember = "ProfessionName";
            cmbProfession.ValueMember = "Id";

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditWorkers = new F_AddEditWorkers();
            addEditWorkers.FormClosing += F_AddEditWorkers_FormClosing;
            addEditWorkers.ShowDialog();
  
        }

        private void F_AddEditWorkers_FormClosing(object sender, FormClosingEventArgs e)
        {
           RefreshHR();
        }


        private void RefreshHR()
        {
            var workers = _fileHelper.DeserializeFromFile();

            var selectedWorkerProfessionId = (cmbProfession.SelectedItem as Profession).Id;
            var selectedWorkerWorkerStatusId = (cmbWorkerStatus.SelectedItem as WorkerStatus).Id;
            var strLastName = txtSearchLastName.Text;


            if (selectedWorkerProfessionId != 0)
            {
                workers = workers.Where(x => x.PositionWork == selectedWorkerProfessionId).ToList();
             }

            if (selectedWorkerWorkerStatusId != 0)
            {
                workers = workers.Where(x => x.WorkerStatus == selectedWorkerWorkerStatusId).ToList();
            }

            if (strLastName !="")
            {
                //workers = workers.Where(x => x.LastName.Contains "%" + strLastName + "%");

                workers = workers.Where(x => x.LastName.ToLower().Contains ($"{strLastName.ToLower()}")).ToList();

            }

            dgvWorkers.DataSource = workers;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego dane chcesz edytować");
                return;
            }
            var addEditWorkers = new F_AddEditWorkers(Convert.ToInt32(dgvWorkers.SelectedRows[0].Cells[0].Value));//tworzymy nowy obiekt klasy
            addEditWorkers.FormClosing += F_AddEditWorkers_FormClosing;
            addEditWorkers.ShowDialog();


            RefreshHR();

        }

        private void SetColumnsHeder()
        {    
            dgvWorkers.Columns[0].HeaderText = "Numer";
            dgvWorkers.Columns[1].HeaderText = "Imię";
            dgvWorkers.Columns[2].HeaderText = "Nazwisko";
            dgvWorkers.Columns[3].HeaderText = "Status zatudnienia";
            dgvWorkers.Columns[4].HeaderText = "Data urodzenia";
            dgvWorkers.Columns[5].HeaderText = "Data zatrudnienia";
            dgvWorkers.Columns[6].HeaderText = "Data zwolnienia";
            dgvWorkers.Columns[7].HeaderText = "Płaca zasadnicza";
            dgvWorkers.Columns[8].HeaderText = "Stanowisko";
            dgvWorkers.Columns[9].HeaderText = "Uwagi";
            dgvWorkers.Columns[10].HeaderText = "Zwolniony";

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            RefreshHR();
        }
    }
}
