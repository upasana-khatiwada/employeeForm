using System.Data;
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


            //--------------------inserting data into database--------------------(method 1)

            //string query = "Insert into Employee " +
            //               " (e_name,e_address,e_age,e_contact)" +
            //               "values (' " +
            //                name1.Text +
            //               "','" + address1.Text +
            //               "','" + age1.Text +
            //               "','" + contact1.Text +
            //               "')";

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
            //con.Close();


            //--------------------inserting data into database--------------------(method 2)
            string query = "Insert into Employee " +
                           " (e_name,e_address,e_age,e_contact)" +
                           "values (@employee_name,@address,@age,@contact )";

            SqlCommand cmd = con.CreateCommand();   
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@employee_name",name1.Text);
            cmd.Parameters.AddWithValue("@address", address1.Text);
            cmd.Parameters.AddWithValue("@age", age1.Text);
            cmd.Parameters.AddWithValue("@contact", contact1.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            //---------------displaying  data into gridview-----------------------------
            //String[] row = new String[5];
            //row[0] = name1.Text.ToString();
            //row[1] = address1.Text.ToString();
            //row[2] = age1.Text.ToString();
            //row[3] = contact1.Text.ToString();
            //dataGridView1.Rows.Add(row);

            //----------------------------------------------------------------------
            string query1 = "Select *from Employee";
            SqlCommand SqlCommand = new SqlCommand(query1,con);
            SqlDataAdapter sda = new SqlDataAdapter(SqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //int sn = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string employee_name = dt.Rows[i]["e_name"].ToString();
                string address = dt.Rows[i]["e_address"].ToString();
                string age = dt.Rows[i]["e_age"].ToString();
                string contact = dt.Rows[i]["e_contact"].ToString();
                dataGridView1.Rows.Add( employee_name, address, age, contact);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            string emp_name = data.Cells["e_name"].Value.ToString();
            string emp_address = data.Cells ["e_address"].Value.ToString();
            string emp_age = data.Cells["e_age"].Value.ToString();
            string  emp_contact = data.Cells["e_contact"].Value.ToString ();

            name1.Text = emp_name;
            address1.Text = emp_address;
            age1.Text = emp_age;
            contact1.Text = emp_contact;



        }

        
    }
}
  