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
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ctx = new TicketsContext())
            {
                string destinationToEdit = textBox1.Text;
                Flight fl = ctx.Flights.Where(fl => fl.Destination == destinationToEdit)
                                       .FirstOrDefault();
                fl.Destination = textBox2.Text;
                fl.FlightNumber = int.Parse(textBox3.Text);
                fl.Price = int.Parse(textBox4.Text);
                int r = ctx.SaveChanges();
                if (r == 1) MessageBox.Show("1 record edited!");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new TicketsContext())
            {
                string destinationToEdit = textBox1.Text;
                Flight fl = ctx.Flights.Where(fl => fl.Destination == destinationToEdit)
                                       .FirstOrDefault();
                if (fl is null)
                {
                    MessageBox.Show("No destination found!");
                }
                else
                {
                    textBox2.Text = fl.Destination;
                    textBox3.Text = fl.FlightNumber.ToString();
                    textBox4.Text = fl.Price.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
