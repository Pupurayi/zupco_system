using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fuelManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fl_all = new Form3();
            this.Hide();
            fl_all.Show();
        }

        private void eeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 orders = new Form4();
            this.Hide();
            orders.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 stock = new Form2();
            this.Hide();
            stock.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 log_in= new Form6();
            this.Hide();
            log_in.Show();
        }
        private void FuelAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }

        private void OrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordersreport form1 = new ordersreport();
            this.Hide();
            form1.Show();
        }
    }
}
