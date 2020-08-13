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
    public partial class ordersreport : Form
    {
        public ordersreport()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 home_page = new Form1();
            this.Hide();

            home_page.Show();
        }

        private void Ordersreport_Load(object sender, EventArgs e)
        {
            String source = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\linda\Documents\vis\ZUPCOSYS.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(source);
            SqlDataReader rdr = null;

            try
            {
                con.Open();
                var query = "SELECT * FROM Orders";

                var dataAdapter = new SqlDataAdapter(query, con);
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
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //create an object myPrintDocument1 of System.Drawing.Printing 
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            //create an object myPrintDialog1 of PrintDialog
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;

            if (myPrinDialog1.ShowDialog() == DialogResult.OK)

            {
                myPrintDocument1.Print();
            }
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            dataGridView1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));

            e.Graphics.DrawImage(myBitmap1, 0, 0);

            myBitmap1.Dispose();
        }
    }
}
