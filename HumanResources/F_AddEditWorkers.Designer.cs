
namespace HumanResources
{
    partial class F_AddEditWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpDateBorn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateGetJob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateFall = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrimSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPositionWork = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbComents = new System.Windows.Forms.TextBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbWorkerStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(121, 29);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(98, 20);
            this.tbId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(121, 55);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(98, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(121, 81);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(293, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // dtpDateBorn
            // 
            this.dtpDateBorn.CustomFormat = "";
            this.dtpDateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBorn.Location = new System.Drawing.Point(121, 139);
            this.dtpDateBorn.Name = "dtpDateBorn";
            this.dtpDateBorn.Size = new System.Drawing.Size(166, 20);
            this.dtpDateBorn.TabIndex = 6;
            this.dtpDateBorn.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data urodzenie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data zatrudnienia:";
            // 
            // dtpDateGetJob
            // 
            this.dtpDateGetJob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateGetJob.Location = new System.Drawing.Point(120, 165);
            this.dtpDateGetJob.Name = "dtpDateGetJob";
            this.dtpDateGetJob.Size = new System.Drawing.Size(168, 20);
            this.dtpDateGetJob.TabIndex = 8;
            this.dtpDateGetJob.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data zwolnienia:";
            // 
            // dtpDateFall
            // 
            this.dtpDateFall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFall.Location = new System.Drawing.Point(121, 192);
            this.dtpDateFall.Name = "dtpDateFall";
            this.dtpDateFall.Size = new System.Drawing.Size(166, 20);
            this.dtpDateFall.TabIndex = 10;
            this.dtpDateFall.Value = new System.DateTime(9997, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Płaca zasadnicza:";
            // 
            // tbPrimSalary
            // 
            this.tbPrimSalary.Location = new System.Drawing.Point(121, 219);
            this.tbPrimSalary.Name = "tbPrimSalary";
            this.tbPrimSalary.Size = new System.Drawing.Size(98, 20);
            this.tbPrimSalary.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stanowisko:";
            // 
            // cmbPositionWork
            // 
            this.cmbPositionWork.FormattingEnabled = true;
            this.cmbPositionWork.Items.AddRange(new object[] {
            "Robotnik fizyczny",
            "Pomocnik magazyniera",
            "Hydraulik",
            "Elektryk",
            "Analityk",
            "Specjalista HR",
            "Księgowy",
            "Dyrektor",
            "Prezes",
            "Stróż",
            "Pracownik administracji"});
            this.cmbPositionWork.Location = new System.Drawing.Point(121, 248);
            this.cmbPositionWork.Name = "cmbPositionWork";
            this.cmbPositionWork.Size = new System.Drawing.Size(304, 21);
            this.cmbPositionWork.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Uwagi:";
            // 
            // tbComents
            // 
            this.tbComents.Location = new System.Drawing.Point(120, 284);
            this.tbComents.MaximumSize = new System.Drawing.Size(400, 80);
            this.tbComents.MinimumSize = new System.Drawing.Size(400, 80);
            this.tbComents.Name = "tbComents";
            this.tbComents.Size = new System.Drawing.Size(400, 20);
            this.tbComents.TabIndex = 17;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(353, 396);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(167, 31);
            this.btnAddEdit.TabIndex = 19;
            this.btnAddEdit.Text = "Dodaj";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 31);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status zatrudnienia:";
            // 
            // cmbWorkerStatus
            // 
            this.cmbWorkerStatus.FormattingEnabled = true;
            this.cmbWorkerStatus.Items.AddRange(new object[] {
            "Zatrudniowny",
            "Zwolniony"});
            this.cmbWorkerStatus.Location = new System.Drawing.Point(124, 107);
            this.cmbWorkerStatus.Name = "cmbWorkerStatus";
            this.cmbWorkerStatus.Size = new System.Drawing.Size(164, 21);
            this.cmbWorkerStatus.TabIndex = 23;
            // 
            // F_AddEditWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbWorkerStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbComents);
            this.Controls.Add(this.cmbPositionWork);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrimSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateFall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDateGetJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateBorn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "F_AddEditWorkers";
            this.Text = "Dodawanie pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpDateBorn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateGetJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateFall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrimSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPositionWork;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbComents;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbWorkerStatus;
    }
}