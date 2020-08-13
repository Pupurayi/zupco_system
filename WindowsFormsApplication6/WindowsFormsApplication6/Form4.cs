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
    public partial class Form4 : Form
    {
        Double iTax = 0.05;
        double unitprice;

        public Form4()
        {
            InitializeComponent();
        }

        private void GrpBox_Enter(object sender, EventArgs e)
        {
            DateTime iDate = DateTime.Now;
            OrderTime.Text = iDate.ToString("HH:mm:ss");

        }
        private void TotalBtn_Click(object sender, EventArgs e)
        {
            string fueltype = Convert.ToString(comboBox1.SelectedItem);
            double quantity = Convert.ToDouble(this.quantity.Text);
            

            Subtotal.Text = Convert.ToString(quantity * unitprice);
            double tempVal = iTax * Convert.ToDouble(Subtotal.Text);
            total.Text = Convert.ToString(tempVal + Convert.ToDouble(Subtotal.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier.Clear();
            SPhone.Clear();
 

            DateTime iDate = DateTime.Now;
            OrderTime.Clear();


            Subtotal.Clear();
            TaxtxtBox.Clear();
            total.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 HOMEPAGE = new Form1();
            this.Hide();
            HOMEPAGE.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string supplier = Supplier.Text;
            string orderdate = Convert.ToString(dateTimePicker1);
            unitprice = Convert.ToDouble(Unit_Price1txtBox.Text);
            string fueltype = Convert.ToString(comboBox1.SelectedItem);
            double totalAmount = Convert.ToDouble(total.Text);

           
            if (supplier.Equals(""))
            {
                MessageBox.Show("Supplier Name Missing!");
            }
            else if (orderdate.Equals(""))
            {
                MessageBox.Show("Order Date Missing!");
            }
            else if (unitprice.Equals(""))
            {
                MessageBox.Show("Fuel Type Not Selected!");
            }
            else if (fueltype.Equals(""))
            {
                MessageBox.Show("Fuel Type Not Selected!");
            }
            else
            {
                String source = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\linda\Documents\vis\ZUPCOSYS.mdf; Integrated Security = True; Connect Timeout = 30";
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    string query = "INSERT INTO Orders (SupplierName, OrderDate, UnitPrice, FuelType, Total) VALUES (@suppliername, @orderdate, @unitprice, @fueltype, @total)";

                    using(SqlCommand insertCommand = con.CreateCommand())
                    {
                        insertCommand.CommandType = CommandType.Text;
                        insertCommand.CommandText = query;

                        insertCommand.Parameters.AddWithValue("@suppliername", supplier);
                        insertCommand.Parameters.AddWithValue("@orderdate", dateTimePicker1.Value);
                        insertCommand.Parameters.AddWithValue("@unitprice", unitprice);
                        insertCommand.Parameters.AddWithValue("@fueltype", fueltype);
                        insertCommand.Parameters.AddWithValue("@total", totalAmount);

                        int rows = insertCommand.ExecuteNonQuery();
                        if(rows == 1)
                        {
                            MessageBox.Show("Record Stored!");
                        }
                        else
                        {
                            MessageBox.Show("Error Saving Order Record!");
                        }
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TaxtxtBox.Text = Convert.ToString(iTax);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fueltype = Convert.ToString(comboBox1.SelectedItem);

            if (fueltype == "Petrol")
            {
                unitprice = 3.30;
            }
            else
            {
                unitprice = 3.10;
            }
            Unit_Price1txtBox.Text = Convert.ToString(unitprice);
        }
    }
}
