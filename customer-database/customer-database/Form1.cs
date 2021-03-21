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

namespace customer_database
{
    public partial class Form1 : Form
    {
        void updateDataTable()
        {
            // Initialize DataTable by querying and inserting all rows from the Customer database.
            string connString;
            SqlConnection conn;

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caden\source\repos\customer-database\customer-database\Local.mdf;Integrated Security=True";
            conn = new SqlConnection(connString);

            string Query = "SELECT * FROM Customer";

            conn.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter(Query, conn);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
            updateDataTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string email = textEmail.Text;
            string region = listBoxRegion.GetItemText(listBoxRegion.SelectedItem);

            bool dataEntryComplete = true;

            // Ensure all forms has been filled out.
            if (name == "" || email == "" || region == "" || (!radioButtonDefault.Checked && !radioButtonPremium.Checked))
                dataEntryComplete = false;

            if (dataEntryComplete)
            {
                // Upload data from form into the Customer database.
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caden\source\repos\customer-database\customer-database\Local.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                string Query = "insert into Customer(name,email,number,region,payment_plan,enrollment_date,submitted_paperwork,signed_terms,previous_customer) values('" + name + "','" + email + "','" + textNumber.Text + "','" + region + "','" + radioButtonPremium.Checked + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + checkBoxPaperwork.Checked + "','" + checkBoxTerms.Checked + "','" + checkBoxPrevCustomer.Checked + "');";
                SqlCommand command = new SqlCommand(Query, conn);

                try
                {
                    conn.Open();

                    SqlDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {

                    }

                    conn.Close();
                    MessageBox.Show("Customer saved successfully.");
                    updateDataTable();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Connection could not be established. Customer data was not saved.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all information fields before continuing.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.localDataSet.Customer);
        }

        private void textName_Leave(object sender, EventArgs e)
        {
            // Upon change, textName will check for numbers and display an error message if found.
            string name = textName.Text;
            int nameLength = name.Length;

            // Name invalid if it contains a number.
            for (int i = 0; i < nameLength; i++)
            {
                if (Char.IsNumber(name[i]))
                {
                    MessageBox.Show("Please input a valid name.");
                    textName.ForeColor = Color.Red;
                    break;
                }
                else
                    textName.ForeColor = Color.Black;
            }
        }

        private void textNumber_Leave(object sender, EventArgs e)
        {
            // Upon losing focus, textNumber will check for characters and display an error message if found.
            string number = textNumber.Text;
            int numberLength = number.Length;

            // Number invalid if longer than 10 digits.
            if (numberLength > 10)
            {
                MessageBox.Show("Please input a valid number.");
                textNumber.ForeColor = Color.Red;
            }
            else
            {
                // Number invalid if it contains a character.
                for (int i = 0; i < numberLength; i++)
                {
                    if (!Char.IsNumber(number[i]))
                    {
                        MessageBox.Show("Please input a valid number.");
                        textNumber.ForeColor = Color.Red;
                        break;
                    }
                    else
                        textNumber.ForeColor = Color.Black;
                }
            }
            
        }
    }
}
