using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CONTACT_TRACING_PROGRAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bAdd_Click(object sender, EventArgs e)
        {
         
            
            Form2 form2 = new Form2(this);
            form2.Show();
            
        }

        public void Delete() 
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
