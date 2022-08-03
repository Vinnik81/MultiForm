using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InfoForm : Form
    {
        private readonly Person person;

        public InfoForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            labelFullName.Text = person.Name + " " + person.Surname;
            textBoxEmail.Text = person.Email;
            textBoxPhone.Text = person.Phone;
            labelBith.Text = person.BirthDate.ToString().Substring(0, 10);
            labelGender.Text = person.Gender.ToString();
            //labelInfo.Text = "Gender: " + person.Gender + "\nBith: " + person.BirthDate;
            pictureBoxPhoto.Image = Image.FromFile(person.PhotoUrl);
            if (person.Favorit) labelFavorit.Visible = true;

        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
