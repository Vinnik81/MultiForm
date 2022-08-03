using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class AddForm : Form
    {
        public enum Mode
        {
            Add, Edit
        }
        private Person Person;
        public string UploadPath { get; set; }
        public Mode mode { get; set; }
        public AddForm()
        {
            InitializeComponent();
            mode = Mode.Add;
            //Person = new Person();
            var currentDirectory = Directory.GetCurrentDirectory();
            UploadPath = $@"{currentDirectory}\Photos\NotFound.png";
            pictureBoxPhoto.Image = Image.FromFile(UploadPath);
        }

        public AddForm(Person person)
        {
            InitializeComponent();
            mode = Mode.Edit;
            textBoxEmail.Text = person.Email;
            textBoxName.Text = person.Name;
            textBoxSurname.Text = person.Surname;
            maskedTextBoxPhone.Text = person.Phone;
            dateTimePickerBith.Value = person.BirthDate;
            checkBoxFavorit.Checked = person.Favorit;

            UploadPath = person.PhotoUrl;
            pictureBoxPhoto.Image = Image.FromFile(UploadPath);

            switch (person.Gender)
            {
                case Gender.Male: radioButtonMale.Checked = true;
                    break;
                case Gender.Female: radioButtonFemale.Checked = true;
                    break;
                case Gender.Other: radioButtonOther.Checked = true;
                    break;
                default:
                    break;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Person = null;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public new Person ShowDialog()
        {
            base.ShowDialog();
            return Person;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Person = new Person();
            Person.Name = textBoxName.Text;
            Person.Surname = textBoxSurname.Text;
            Person.Phone = maskedTextBoxPhone.Text;
            Person.Email = textBoxEmail.Text;
            Person.BirthDate = dateTimePickerBith.Value;
            Person.Favorit = checkBoxFavorit.Checked;

            if (radioButtonMale.Checked) Person.Gender = Gender.Male;
            else if (radioButtonFemale.Checked) Person.Gender = Gender.Female;
            else if (radioButtonOther.Checked) Person.Gender = Gender.Other;

            Person.PhotoUrl = UploadPath;
            //Person.PhotoUrl = pictureBoxPhoto.Image.ToString();
            this.Close();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.png)| * .jpg; * .png";
           var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var newPath = SavePhoto(dialog.FileName);
                UploadPath = newPath;
                //Person.PhotoUrl = newPath;
                pictureBoxPhoto.Image = Image.FromFile(newPath);
                //MessageBox.Show(dialog.FileName.ToString(), "Contact info");
            }
        }

        public string SavePhoto(string path)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            try
            {
                if (!Directory.Exists($@"{currentDirectory}\Photos"))
                {
                    Directory.CreateDirectory($@"{currentDirectory}\Photos");
                }
                var extension = Path.GetExtension(path);
                var newPath = $@"{currentDirectory}\Photos\{Guid.NewGuid()}{extension}";
                File.Copy(path, newPath);
                return newPath;
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}
