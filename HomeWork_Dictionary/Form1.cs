using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Dictionary
{
    public partial class Form1 : Form
    {
        ComboBox combobox;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            comboBoxFrom.SelectedItem = "Русский";
            comboBoxTo.SelectedItem = "Английский";
            combobox = new ComboBox();
            combobox.Items.AddRange(new object[] {
                "Русский",
                "Английский",
                "Немецкий" });
            form2 = new Form2();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //Translate.SaveRuEn();
            //Translate.SaveRuDe();
            //base.OnClosing(e);
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            combobox.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = comboBoxFrom.SelectedItem;
            comboBoxFrom.SelectedItem = combobox.SelectedItem;
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                var translate = richTextBoxFrom.TextLength;
                if (translate != 0)
                {
                    //if (comboBoxFrom.Text == "Русский" && comboBoxTo.Text == "Английский")
                    //    richTextBoxTo.Text = Translate.TransRuEn(richTextBoxFrom.Text);
                    //else if (comboBoxFrom.Text == "Английский" && comboBoxTo.Text == "Русский")
                    //    richTextBoxTo.Text = Translate.TransRuEn(richTextBoxFrom.Text);
                    //else if (comboBoxFrom.Text == "Русский" && comboBoxTo.Text == "Немецкий")
                    //    richTextBoxTo.Text = Translate.TransRuDe(richTextBoxFrom.Text);
                    //else if (comboBoxFrom.Text == "Немецкий" && comboBoxTo.Text == "Русский")
                    //    richTextBoxTo.Text = Translate.TransRuDe(richTextBoxFrom.Text);
                }
                else MessageBox.Show("Вы не ввели слова для перевода!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("Нет такого слова в словаре!", "Errtor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void richTextBoxFrom_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxFrom.Clear();
            richTextBoxTo.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
