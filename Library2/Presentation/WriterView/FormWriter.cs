using Core;
using Core.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.WriterView
{
    public partial class FormWriter : Form
    {
        Person? SelectedPerson = null;
        Writer? Model = null;
        libraryContext Context = Database.Context;
        public FormWriter(Writer? writer = null)
        {
            InitializeComponent();
            Model = writer;
        }

        private void Select_Person_Click(object sender, EventArgs e)
        {
            FormPersonList form = new FormPersonList();
            form.ShowDialog();
            if (form.Model != null)
            {
                if (Context.Writers.Any(p => p.Persons.Id == form.Model.Id))
                {
                    MyMessageBox.ValidationErrorMessage("duplicate Person");
                    return;
                }
                SelectedPerson = form.Model;
                lbl_Selectedperson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (SelectedPerson == null)
            {
                MyMessageBox.SelectionErrorMessage("Select a Person");
                return;
            }
         
            if (Model == null)
            {
                Model = new Writer();
                Context.Add(Model);
            }
            Model.Persons = SelectedPerson;
            Model.Biography = txt_Bio.Text.Trim();

            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            Close();
        }

        private void FormWriter_Load(object sender, EventArgs e)
        {
            if (Model != null)
            {
                SelectedPerson = Model.Persons;
                txt_Bio.Text = Model.Biography;
                lbl_Selectedperson.Text = SelectedPerson?.FirstName + " " + SelectedPerson?.LastName;
            }

        }
    }
}
