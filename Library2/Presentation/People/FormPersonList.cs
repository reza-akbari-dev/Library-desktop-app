using Core;
using Core.Data;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.People;

namespace Presentation.People
{
    public partial class FormPersonList : Form
    {
        libraryContext Context = Database.Context;
        public Person? Model { get; set; } = null;
        
        public FormPersonList()
        {
            InitializeComponent();
        }

        private void Submit_Person_Click(object sender, EventArgs e)
        {
            new FormPerson().ShowDialog();
            ShowPeople();
        }

        private void FormPersonList_Load(object sender, EventArgs e)
        {
            ShowPeople();
        }

        private void ShowPeople()
        {
            string firstName = txt_FristName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            long nationalCode = txt_NationalCode.ToLong();

            var _list = Context.Persons.Where(p => p.FirstName.Contains(firstName) && p.LastName.Contains(lastName) &&
            (p.NationalCode == nationalCode || nationalCode == 0)).
            Select(Person => new PeopleSearchModel
            {
                Id = Person.Id,
                FirstName = Person.FirstName,
                LastName = Person.LastName,
                NationalCode = Person.NationalCode,
                PersonPicture = Person.PersonPicture.Picture
            });
            Grid_People_List.DataSource = _list.ToList();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            ShowPeople();

        }

        private void Grid_People_List_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int id = Grid_People_List["CelId", e.RowIndex].Value.ToInt();
            Model = Context.Persons.Find(id);

        }

        private void Edit_Clik(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            FormPerson person = new FormPerson(Model);
            person.ShowDialog();
            ShowPeople();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if(MyMessageBox.ConfirmedMessage())
            {
                Context.Persons.Remove(Model);
                Context.SaveChanges();
                MyMessageBox.SuccessMessage();
                ShowPeople();
            }
            return;
        }

        private void Grid_People_List_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1) return;
            int id = Grid_People_List["CelId", e.RowIndex].Value.ToInt();
            Model =Context.Persons.Find(id);
            Close();
        }
    }
}
