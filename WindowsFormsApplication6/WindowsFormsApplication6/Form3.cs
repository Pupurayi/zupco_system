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
    

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(textBox1.Text);
            string name = textBox4.Text;
            string busid = textBox3.Text;
            string fuelall = Convert.ToString(comboBox1.SelectedItem);
            double quantity = Convert.ToDouble(textBox6.Text);
            string dest = textBox5.Text;
            string date = Convert.ToString(dateTimePicker1);

            String source = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\linda\Documents\vis\ZUPCOSYS.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection databasecon = new SqlConnection(source))
            {
                databasecon.Open();

                string addquery = "INSERT INTO Fuel_allocation (Emp_ID, Name, Bus_ID, Fuel_Type_Allocated, Quantity, Destination, Date) VALUES (@empID, @name, @busid, @fuelall, @quantity, @dest, @date)";

                using (SqlCommand insertCommand = databasecon.CreateCommand())
                {
                    insertCommand.CommandType = CommandType.Text;
                    insertCommand.CommandText = addquery;

                    insertCommand.Parameters.AddWithValue("@empID", empID);
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@busid", busid);
                    insertCommand.Parameters.AddWithValue("@fuelall", fuelall);
                    insertCommand.Parameters.AddWithValue("@quantity", quantity);
                    insertCommand.Parameters.AddWithValue("@dest", dest);
                    insertCommand.Parameters.AddWithValue("@date", date);


                    int rows = insertCommand.ExecuteNonQuery();

                    if (rows == 1)
                    {
                        if(fuelall == "Petrol")
                        {
                            removeFromAvailable(quantity);
                        }
                        else if(fuelall == "Diesel")
                        {
                            removeFromAvailable2(quantity);
                        }
                        MessageBox.Show("INSERTED!");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                databasecon.Close();
            }
        }
        public void removeFromAvailable(double fuelAmount)
        {
            string fuelType;

            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\linda\Documents\vis\ZUPCOSYS.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(source))
            {
                con.Open();
                string query = "SELECT * FROM Stock WHERE FuelType = 'Petrol'";
                using (SqlCommand addToCommand = con.CreateCommand())
                {
                    addToCommand.CommandType = CommandType.Text;
                    addToCommand.CommandText = query;

                    using (var reader = addToCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            double available = 0;
                            fuelType = Convert.ToString(reader["FuelType"]);
                            available = Convert.ToDouble(reader["Available"]);

                            double newAvailable = available - fuelAmount;
                            string query2 = "UPDATE Stock SET FuelType = 'Petrol', Available = '" + newAvailable + "' WHERE FuelType = 'Petrol'";

                            using (SqlCommand updateCommand = con.CreateCommand())
                            {
                                updateCommand.CommandType = CommandType.Text;
                                updateCommand.CommandText = query2;

                                updateCommand.Parameters.AddWithValue("@Available", newAvailable);

                                int row = updateCommand.ExecuteNonQuery();

                                if (row == 1)
                                {
                                    MessageBox.Show("Successfully Updated Fuel Available");
                                }
                                else
                                {
                                    MessageBox.Show("Error Updating Fuel Available");
                                }
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void removeFromAvailable2(double fuelAmount)
        {
            string fuelType;

            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\ZUPCOSYS.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(source))
            {
                con.Open();
                string query = "SELECT * FROM Stock WHERE FuelType = 'Diesel'";
                using (SqlCommand addToCommand = con.CreateCommand())
                {
                    addToCommand.CommandType = CommandType.Text;
                    addToCommand.CommandText = query;

                    using (var reader = addToCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            double available = 0;
                            fuelType = Convert.ToString(reader["FuelType"]);
                            available = Convert.ToDouble(reader["Available"]);

                            double newAvailable = available - fuelAmount;
                            string query2 = "UPDATE Stock SET FuelType = 'Diesel', Available = '" + newAvailable + "' WHERE FuelType = 'Diesel'";

                            using (SqlCommand updateCommand = con.CreateCommand())
                            {
                                updateCommand.CommandType = CommandType.Text;
                                updateCommand.CommandText = query2;

                                updateCommand.Parameters.AddWithValue("@Available", newAvailable);

                                int row = updateCommand.ExecuteNonQuery();

                                if (row == 1)
                                {
                                    MessageBox.Show("Successfully Updated Fuel Available");
                                }
                                else
                                {
                                    MessageBox.Show("Error Updating Fuel Available");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 home_page = new Form1();
            this.Hide();
            home_page.Show();
        }
    }
}
