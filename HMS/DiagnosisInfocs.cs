using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_By_Shiva
{
    public partial class DiagnosisInfo : Form
    {
        public DiagnosisInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox2.Text);
                
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=hospital; integrated security=true";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + " " ;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                int contact = Convert.ToInt32(textBox2.Text);
                String sympt = txtBxSymptoms.Text;
                String diag = txtBxDiagnosis.Text;
                String medicine = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=hospital; integrated security=true";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into PatientMore values (" + pid + "," + contact + ",'" + sympt + "','" + diag + "', '" + medicine + "', ' " + ward + " ' , '" + wardType + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }

            catch(Exception)
            {
                MessageBox.Show("Any field is empty 'OR' Data is in WRONG format");
            }

            MessageBox.Show("Data Saved");

            textBox1.Clear();
            textBox2.Clear();
            txtBxDiagnosis.Clear();
            txtBxMedicines.Clear();
            txtBxSymptoms.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();



        }

        private void txtBxSymptoms_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
