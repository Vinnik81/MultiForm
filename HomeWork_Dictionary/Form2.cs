using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeWork_Dictionary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxRu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRu_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBoxEn_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBoxDe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                listBoxDe.Items.Add(textBoxDe.Text);
                listBoxEn.Items.Add(textBoxEn.Text);
                listBoxRu.Items.Add(textBoxRu.Text);
                textBoxRu.Text = "";
                textBoxEn.Text = "";
                textBoxDe.Text = "";
                textBoxRu.Focus();
            }
        }
    }
}
