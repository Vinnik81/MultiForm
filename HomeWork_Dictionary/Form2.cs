using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace HomeWork_Dictionary
{
    public partial class Form2 : Form
    {
        public  Dictionary<string, string> dictionaryRuEn { get; set; } = new Dictionary<string, string>();
        public  Dictionary<string, string> dictionaryRuDe { get; set; } = new Dictionary<string, string>();
        public Form2()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            SaveRuEn();
            SaveRuDe();
            base.OnClosing(e);
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
                public void SaveRuEn()
                {
                    dictionaryRuEn.Add(listBoxRu.Items.ToString(), listBoxEn.Items.ToString());
                    //dictionaryRuEn.Add(listBoxEn.Text, listBoxRu.Text);
                    var strRuEn = JsonSerializer.Serialize(dictionaryRuEn);
                    File.WriteAllText("dictionaryRuEn.json", strRuEn);
                }
        public void SaveRuDe()
        {
            dictionaryRuDe.Add(listBoxRu.Items.ToString(), listBoxDe.Items.ToString());
            //dictionaryRuDe.Add(listBoxDe.Text, listBoxRu.Text);
            var strRuDe = JsonSerializer.Serialize(dictionaryRuDe);
            File.WriteAllText("dictionaryRuDe.json", strRuDe);
        }
    }
}
