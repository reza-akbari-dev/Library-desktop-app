using Castle.Components.DictionaryAdapter;
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
using ViewModel.Writer;

namespace Presentation.WriterView
{
    public partial class FormWriterList : Form
    {
        libraryContext Context = Database.Context;
        public Writer? Model { get; set; } = null;
        public FormWriterList()
        {
            InitializeComponent();
        }

        private void FormWriterList_Load(object sender, EventArgs e)
        {
            ShowWriters();
        }

        private void ShowWriters()
        {
            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            string biography = txt_Bioghraphy.Text.Trim();

            var _list = Context.Writers.Where(p => p.Persons.FirstName.Contains(firstName) && p.Persons.LastName.Contains(lastName)
            /*&& p.Biography.Contains(biography)*/)
             .Select(writer
             => new WriterSearchModel
             {
                 Id = writer.Id,
                 FirstName = writer.Persons.FirstName,
                 LastName = writer.Persons.LastName,
                 Biography = writer.Biography,
             });
            Grid_Writers.DataSource = _list.ToList();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowWriters();
        }

        private void Grid_Writers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            int id = Grid_Writers["colid", e.RowIndex].Value.ToInt();
            Model = Context.Writers.Find(id);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            new FormWriter().ShowDialog();
            ShowWriters();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            FormWriter form = new FormWriter(Model);
            form.ShowDialog();
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if (MyMessageBox.ConfirmedMessage())
            {
                Context.Writers.Remove(Model);
                Context.SaveChanges();
                ShowWriters();
                MyMessageBox.SuccessMessage();
            }
            return;
        }

        private void Grid_Writers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            int id = Grid_Writers["colid", e.RowIndex].Value.ToInt();
            Model = Context.Writers.Find(id);
            Close();
        }
    }
}
