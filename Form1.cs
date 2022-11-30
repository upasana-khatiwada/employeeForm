using System.Data.SqlClient;

namespace employeeform
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
           @"Data Source= .\SQLEXPRESS; 
            Initial Catalog= employee;
            user id =sa ; 
            password =kist@123;");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


    
        private void name1_TextChanged(object sender, EventArgs e)
        {
            string e_name = name1.Text;
        }

        private void address1_TextChanged(object sender, EventArgs e)
        {
            string e_address = address1.Text; 
        }

        private void age1_TextChanged(object sender, EventArgs e)
        {
            string e_age = age1.Text;
        }

        private void contact1_TextChange(object sender, EventArgs e)
        {
            string e_contact = contact1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Employee " +
               " (e_name,e_address,e_age,e_contact)" +
               "values (' " +
               name1.Text +
               "','" + address1.Text +
               "','" + age1.Text +
               "','" + contact1.Text +
               "')";

            SqlCommand cmd = con.CreateCommand();   
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            String[] row = new String[5];
            row[0] = name1.Text.ToString();
            row[1] = address1.Text.ToString();
            row[2] = age1.Text.ToString();
            row[3] = contact1.Text.ToString();
            dataGridView1.Rows.Add(row);
        }
    }
}