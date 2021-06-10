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
    public partial class Form2 : Form
    {
        Form1 data;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.data = f1;
        }

        string Gender = "";
        

        private void bCancel_Click(object sender, EventArgs e)
        {


            this.Close();
            
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {

            data.dataGridView1.Rows.Add(tbName.Text,tbAddress.Text, tbContact.Text,Gender,tbTemp.Text,dt.Text);
            if (tbName.Text == "" || tbAddress.Text == "" || tbContact.Text == "" || Gender == null || tbTemp.Text == "") 
            {
               MessageBox.Show("Required Field is empty");
               data.dataGridView1.Rows.Clear();
            }
            this.Close();
           
        }

        private void ADDRESS(object sender, EventArgs e)
        {

        }

        private void rbMale(object sender, EventArgs e)
        {
            
            if (rmale.Checked) 
            {
                Gender = rmale.Text;
            }


        }

        private void rbFemale(object sender, EventArgs e)
        {
            if (rfemale.Checked)
            {
                Gender = rfemale.Text;
            }

        }

        private void tbTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == 46 && tbTemp.Text.IndexOf(".") != -1) 
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(c) && c != 8 && c != 46)
            {
            e.Handled = true;
            }

        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
