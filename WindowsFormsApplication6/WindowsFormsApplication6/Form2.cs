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

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home_page = new Form1();
            this.Hide();

            home_page.Show();
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\linda\Documents\vis\ZUPCOSYS.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection databasecon = new SqlConnection(source);

                SqlDataReader rdr = null;

                try
                {
                    databasecon.Open();

                    var query = "SELECT Available FROM Stock WHERE Fueltype = 'Diesel'";
                    var dataAdapter = new SqlDataAdapter(query, databasecon);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (databasecon != null)
                    {
                        databasecon.Close();
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                String source = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\linda\Documents\vis\ZUPCOSYS.mdf; Integrated Security = True; Connect Timeout = 30";
                SqlConnection databasecon = new SqlConnection(source);

                SqlDataReader rdr = null;

                try
                {
                    databasecon.Open();

                    var query = "SELECT Available FROM Stock WHERE Fueltype = 'Petrol'";
                    var dataAdapter = new SqlDataAdapter(query, databasecon);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (databasecon != null)
                    {
                        databasecon.Close();
                    }
                }
            }
        }
      
    }
}
