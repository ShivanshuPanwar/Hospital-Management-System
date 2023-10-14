using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_By_Shiva
{
    public partial class PatientRecord : Form
    {
        public PatientRecord()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
       {

       }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                String name = txtName.Text;
                String gender = comboGender.Text;
                int age = Convert.ToInt32(txtAge.Text);
                String blood = comboBlood.Text;
       
                Int64 contact = Convert.ToInt64(txtContactNo.Text);
                String address = txtAddress.Text;
                String relationship = comboRelationship.Text;
                String disease = txtMajorDisease.Text;
                String pid = txtPId.Text;
                String attendantname = txtAttendantName.Text;


                // SqlConnection con = new SqlConnection("Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=DOTNET; integrated security=true");
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=hospital; integrated security=true";

                //String str = "Create table AddPatient(Name varchar(150), Gender varchar(10), Age int, Blood_Group varchar(20), Guardian_Name varchar(150), Contact_No bigint , Address varchar(150), Relationship varchar(150), Major_Disease varchar(400))";
               // String str = txtquery.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //MessageBox.Show("Query Executed");

                


               cmd.CommandText = "insert into AddPatient values ('" + name + "', ' " + gender + "' , " + age + " , '" + blood + "' ," + contact + " , ' " + address + " ' , ' " + relationship + " ' , ' " + disease + " ','" + pid + "', '" + attendantname + "')";

               SqlDataAdapter DA = new SqlDataAdapter(cmd);
               DataSet DS = new DataSet();
               DA.Fill(DS);

            }

            catch(Exception)
            {
                MessageBox.Show("Invalid data format");
            }

            MessageBox.Show("Data is Stored Successfully");

            txtName.Clear();
            comboGender.ResetText();
            txtAge.Clear();
            comboBlood.ResetText();
            txtContactNo.Clear();
            txtAddress.Clear();
            comboRelationship.ResetText();
            txtMajorDisease.Clear();
            txtPId.Clear();
            txtAttendantName.Clear();





        }

      private void txtMajorDisease_TextChanged(object sender, EventArgs e)
       {

       }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 

           // try
           // {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=hospital; integrated security=true";
               
            con.Open();
                string str= "DELETE FROM AddPatient WHERE PId= '" + txtPId.Text +  "'";
            SqlCommand cmd = new SqlCommand(str,con);
            cmd.ExecuteNonQuery();
            //    DataSet DS = new DataSet();
            //    DA.Fill(DS);
            //  }
            //  catch(Exception)
            //  {
            MessageBox.Show("Incorrect query");
          //  }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
