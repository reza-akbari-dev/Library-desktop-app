using Core;
using Core.Data;
using Domain.Entities;
using Presentation.WriterView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.Writer;

namespace Presentation.BookView
{
    public partial class FormBook : Form
    {
        Book? Model = null;
        libraryContext Context = Database.Context;
        public FormBook(Book? book = null)
        {
            InitializeComponent();
            Model = book;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            ShowSubjectList();
            if (Model != null)
            {
                ShowSelectedBookInfo();
            }
        }

        private void ShowSelectedBookInfo()
        {
            txt_BookName.Text = Model?.BookName;
            txt_Abstract.Text = Model?.Abstract;
            txt_ISBN.Text = Model?.ISBN;
            combo_BookSubject.SelectedValue = Model.SubjectId;
        }
        private void ShowSubjectList()
        {
            combo_BookSubject.DataSource = Database.Context.Subjects.ToList();
            combo_BookSubject.DisplayMember = "SubjectName";
            combo_BookSubject.ValueMember = "Id";
            combo_BookSubject.SelectedIndex = -1;
        }

        private void Regester_Book_Click(object sender, EventArgs e)
        {
            if (txt_BookName.Text.Trim() == "" || txt_ISBN.Text.Trim() == "" || combo_BookSubject.SelectedIndex == -1)
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            if (Model == null)
            {

                Model = new Book();
                Database.Context.Books.Add(Model);
            }

            //edit
            Model.BookName = txt_BookName.Text.Trim();
            Model.ISBN = txt_ISBN.Text.Trim();
            Model.Abstract = txt_Abstract.Text.Trim();
            Model.SubjectId = Convert.ToInt32(combo_BookSubject.SelectedValue);

            Database.Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            Close();
        }
        #region Book Writer
        private void Choose_Writer_Click(object sender, EventArgs e)
        {
            FormWriterList form = new FormWriterList();
            form.ShowDialog();
            if (form.Model != null && Model != null)
            {
                Model.Writers.Add(form.Model);
                Context.SaveChanges();
                MyMessageBox.SuccessMessage();
                ShowBookWriters();
            }

        }
        private void tabContr_Writer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabContr_Writer.SelectedIndex == 1 && Model == null)
            {
                MyMessageBox.ValidationErrorMessage("Enter the writer Info");
                tabContr_Writer.SelectedIndex = 0;
                return;
            }
            ShowBookWriters();
        }

        private void ShowBookWriters()
        {
            var _list = Model?.Writers.Select(p => new WriterSearchModel
            {
                FirstName = p.Persons?.FirstName,
                LastName = p.Persons?.LastName,
                Biography = p.Biography,
                Id = p.Id,
            }).ToList();
            Grid_writer.AutoGenerateColumns = false;
            Grid_writer.DataSource = _list;

        }
        #endregion
        private void Grid_writer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                int id = Grid_writer["CelId", e.RowIndex].Value.ToInt();
                var _writer = Model?.Writers.FirstOrDefault(p => p.Id == id);
                if (MyMessageBox.ConfirmedMessage())
                {
                    Model?.Writers.Remove(_writer);
                    Context.SaveChanges();
                    ShowBookWriters();
                    MyMessageBox.SuccessMessage();
                }
                return;



            }
        }
    }
}
