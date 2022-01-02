using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LoginEntities db = new LoginEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var Events = (from x in db.Events
                          select new
                          {
                              x.EventId,
                              x.EventName,
                              x.Date,
                              x.Free,
                              x.UnitPrice,
                              x.Capacity,
                              x.Faculty,
                              x.Department,
                              x.Information,
                              x.Image
                          }).ToList();
            dataGridView1.DataSource = Events;

           // textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //// frm.a = textBox1.Text;
            //frm.a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //frm.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 frm = new Form2();
            frm.a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.Show();
        }
    }
}
