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
    public partial class FullHistoryOfPatient : Form
    {
        public FullHistoryOfPatient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data source=LAPTOP-INKJ6BUS\\SHIVA; Database=hospital; integrated security=true";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.PId = PatientMore.PId";     // this is join query
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];


        }
    }
}
