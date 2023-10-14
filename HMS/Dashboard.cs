using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_By_Shiva
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //label1_Click_1

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
            PatientRecord fm2 = new PatientRecord();
            fm2.Show();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
            DiagnosisInfo di2 = new DiagnosisInfo();
            di2.Show();
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelIndecator3.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            FullHistoryOfPatient fhop = new FullHistoryOfPatient();
            fhop.Show();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;

            HospitalInfocs hic = new HospitalInfocs();
            hic.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }
    }
}
