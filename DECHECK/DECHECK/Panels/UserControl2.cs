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

namespace DECHECK.Panels
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Student Order by Surname", DataClass.ALLData.ConnStr);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            comboBox1.DataSource = dataSet.Tables[0];
            comboBox1.ValueMember = "id_Student";
            comboBox1.DisplayMember = "name";
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select * From Exams where id_student like '{comboBox1.SelectedValue}%'", DataClass.ALLData.ConnStr);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select * From Exams where id_student like '{comboBox1.SelectedValue}%'", DataClass.ALLData.ConnStr);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
