using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public List<Person> People { get; set; } = new List<Person>();
        public MainForm()
        {
            InitializeComponent();
            var currentDirectory = Directory.GetCurrentDirectory();
           var UploadPath = $@"{currentDirectory}\Photos\NotFound.png";
            //People = new List<Person>()
            //{
            //    new Person
            //    {
            //        Name = "Владимир",
            //        Surname = "Винник",
            //        BirthDate = new DateTime(1981, 12, 15),
            //        Phone = "+79689703252",
            //        Email = "358979037vvv@gmail.com",
            //        Favorit = true,
            //        Gender = Gender.Male,
            //        PhotoUrl = UploadPath
            //    },
            //     new Person
            //    {
            //        Name = "Ульяна",
            //        Surname = "Винник",
            //        BirthDate = new DateTime(2012, 03, 10),
            //        Phone = "+79014283453",
            //        Email = "uliana10032012vvv@gmail.com",
            //        Favorit = true,
            //        Gender = Gender.Female,
            //         PhotoUrl = UploadPath
            //     },
            //     new Person
            //    {
            //        Name = "Юлия",
            //        Surname = "Боцман",
            //        BirthDate = new DateTime(1985, 01, 25),
            //        Phone = "+79859564585",
            //        Email = "juliavvv@gmail.com",
            //        Favorit = false,
            //        Gender = Gender.Female,
            //         PhotoUrl = UploadPath
            //     }
            //};
            Load();
            if (People != null && People.Count > 0) 
            listBoxPeople.Items.AddRange(People.ToArray());
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Save();
            base.OnClosing(e);
        }
        public void Save()
        {
          var str = JsonSerializer.Serialize(People);
            File.WriteAllText("people.json", str);
        }
        public void Load()
        {
            var json = File.ReadAllText("people.json");
           People = JsonSerializer.Deserialize<List<Person>>(json);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //var index = listBoxPeople.SelectedIndex;
            //MessageBox.Show(index.ToString(), "Contact info");
            //MessageBox.Show(People[index].ToString(), "Contact info");

            var person = listBoxPeople.SelectedItem as Person;
            if (person != null)
            {
                var infoForm = new InfoForm(person);
                //infoForm.Show();
                //this.Hide();
                infoForm.ShowDialog();
               // MessageBox.Show(person.ToString(), "Contact info");
            }
            else
            MessageBox.Show("Пожалуйста выбирите человека", "Contact info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            var person = addForm.ShowDialog();

            if (person != null)
            {
                People.Add(person);
                listBoxPeople.Items.Add(person);
                //listBoxPeople.Items.Clear();
                //listBoxPeople.Items.AddRange(People.ToArray());
            }

            //if (dialog == DialogResult.OK)
            //{
            //    var person = addForm.Person;
            //        People.Add(person);
            //        listBoxPeople.Items.Add(person);
            //}
            //addForm.ShowDialog();
            //var person = addForm.Person;

            //if (person != null)
            //{
            //People.Add(person);
            //    listBoxPeople.Items.Add(person);
            //}
        }

        private void listBoxPeople_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var person = listBoxPeople.SelectedItem as Person;
            if (person != null)
            {
                var infoForm = new InfoForm(person);
                infoForm.ShowDialog();
               
            }
            else
                MessageBox.Show("Пожалуйста выбирите человека", "Contact info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var person = listBoxPeople.SelectedItem as Person;
            if (person != null)
            {
                People.Remove(person);
                listBoxPeople.Items.Clear();
                listBoxPeople.Items.AddRange(People.ToArray());
            }
            else
                MessageBox.Show("Пожалуйста выбирите человека", "Contact info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selected = listBoxPeople.SelectedItem as Person;
            if (selected != null)
            {
                var addForm = new AddForm(selected);
               var person =  addForm.ShowDialog();
            if (person != null)
            {
                    var index = listBoxPeople.SelectedIndex;
                    People.RemoveAt(index);
                    listBoxPeople.Items.RemoveAt(index);

                    People.Insert(index, person);
                    listBoxPeople.Items.Insert(index, person);
                }
            }
            else
                MessageBox.Show("Пожалуйста выбирите человека", "Contact info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
