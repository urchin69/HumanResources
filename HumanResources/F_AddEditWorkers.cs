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
    public partial class F_AddEditWorkers : Form
    {


        private int _workersId;

        private Workers _workers;

        public List<WorkerStatus> _workersStatus;
        public List<Profession> _workersProfession;

        //public List<Classes> _classes;

        private HelperAddEdit<List<Workers>> _fileHelper = new HelperAddEdit<List<Workers>>(Program.FilePath);
        public F_AddEditWorkers(int id = 0)//konstruktor
        {
            InitializeComponent();
            _workersId = id;

            _workersStatus = HelperWorkerStatus.GetWorkerStatus("Brak");
            _workersProfession = HelperProfession.GetProfession("Brak");
            
            InitGroupsComboBox();

            GetWorkersData();

            tbFirstName.Select();
        }

        private void InitGroupsComboBox()
        {
            cmbWorkerStatus.DataSource = _workersStatus;//inicjalizacja ComboBox
            cmbWorkerStatus.DisplayMember = "StatusName";
            cmbWorkerStatus.ValueMember = "Id";


          cmbPositionWork.DataSource = _workersProfession;//inicjalizacja ComboBox
            cmbPositionWork.DisplayMember = "ProfessionName";
            cmbPositionWork.ValueMember = "Id";

        }



        private void GetWorkersData()
        {
            if (_workersId != 0)
            {//edycja danych
                Text = "Edytowanie pracownika";
                var workers = _fileHelper.DeserializeFromFile();

                _workers = workers.FirstOrDefault(x => x.Id == _workersId);

                btnAddEdit.Text = "Zapisz zmiany";


                if (_workers == null)
                {
                    throw new Exception("Brak użytkownika o podanym Id");
                }

                FillTextBoxes();
            }

        }

        private void FillTextBoxes()
        {
            tbId.Text = _workers.Id.ToString();
            tbFirstName.Text = _workers.FirstName;
            tbLastName.Text = _workers.LastName;

            cmbWorkerStatus.SelectedItem = _workersStatus.FirstOrDefault(x => x.Id == _workers.WorkerStatus);//_workers.WorkerStatus;

            dtpDateBorn.Value = _workers.DateBorn;
            dtpDateGetJob.Value = _workers.DateGetJob;
            dtpDateFall.Value = (DateTime)_workers.DateFall;
            nudPrimSalary.Value = _workers.PrimSalary;

            cmbPositionWork.SelectedItem = _workersProfession.FirstOrDefault(x => x.Id == _workers.PositionWork); //_workers.PositionWork;

            tbComents.Text = _workers.Coments;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AssignIdNewWorker(List<Workers> workers)
        {
            var workersWithHighestID = workers.OrderByDescending(x => x.Id).FirstOrDefault();
            _workersId = workersWithHighestID == null ? 1 : workersWithHighestID.Id + 1;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            var workers= _fileHelper.DeserializeFromFile();


            if (_workersId != 0)
            {
                workers.RemoveAll(x => x.Id == _workersId);
            }
            else
            {
                AssignIdNewWorkers(workers);
            }

            AddNewUserToList(workers);

            _fileHelper.SerializeToFile(workers);

            Close();
        }

        private void AddNewUserToList(List<Workers> workers)
        {

            var worker = new Workers
            {
       

                Id = _workersId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,

                WorkerStatus = (cmbWorkerStatus.SelectedItem as WorkerStatus).Id,//(cmbWorkerStatus.SelectedItem as WorkerStatus).Id,   // cmbWorkerStatus.SelectedItem.ToString(),
               
                DateBorn = dtpDateBorn.Value,
                DateGetJob = dtpDateGetJob.Value,
                DateFall = dtpDateFall.Value,
                PrimSalary = nudPrimSalary.Value,
                PositionWork =(cmbPositionWork.SelectedItem as Profession).Id,   // int.Parse(cmbPositionWork.SelectedItem.ToString()),
                Coments = tbComents.Text

            };

            workers.Add(worker);
        }
        private void AssignIdNewWorkers(List<Workers> workers)
        {
            var workerWithHighestID = workers.OrderByDescending(x => x.Id).FirstOrDefault();
            _workersId = workerWithHighestID == null ? 1 : workerWithHighestID.Id + 1;
        }

        private void F_AddEditWorkers_Load(object sender, EventArgs e)
        {
            dtpDateGetJob.Value = DateTime.Now;
           
        }
    }
}
