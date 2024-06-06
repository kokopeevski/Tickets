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
    public partial class Form1 : Form
    {
        public static int idToEdit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var ctx = new TicketsContext())
            {
                dataGridView1.DataSource = ctx.Flights.OrderBy(fl => fl.Destination)
                                                      .ToList();
            }
            dataGridView1.Columns["Destination"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddData ad = new AddData();
            ad.ShowDialog();
            this.LoadData();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditData ed = new ();
            ed.ShowDialog();
            this.LoadData();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idToEdit = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            this.Hide();
            RemoveData rd = new();
            rd.ShowDialog();
            this.LoadData();
            this.Show();
        }
    }
}
