using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Models;

namespace Tickets
{
    public partial class RemoveData : Form
    {
        public RemoveData()
        {
            InitializeComponent();
        }

        private void RemoveData_Load(object sender, EventArgs e)
        {
            using (var ctx = new TicketsContext())
            {
                Flight fl = ctx.Flights.Where(fl => fl.Id == Form1.idToEdit)
                                       .FirstOrDefault();
                textBox1.Text = fl.FlightNumber.ToString();
                textBox2.Text = fl.Destination;
                textBox3.Text = fl.Price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new TicketsContext())
            {
                Flight fl = ctx.Flights.Where(fl => fl.Id == Form1.idToEdit)
                                       .FirstOrDefault();
                ctx.Remove(fl);
                int r = ctx.SaveChanges();
                if(r == 1) MessageBox.Show("1 record removed!");
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
