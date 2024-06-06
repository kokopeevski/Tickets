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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new TicketsContext())
            {
                Flight fl = new Flight()
                {
                    FlightNumber = int.Parse(textBox1.Text),
                    Destination = textBox2.Text,
                    Price = int.Parse(textBox3.Text)
                };
                ctx.Flights.Add(fl);
                int r = ctx.SaveChanges();
                if (r == 1) MessageBox.Show("+1 record!");
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
