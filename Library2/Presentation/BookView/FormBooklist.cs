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
using ViewModel.Book;
using ViewModel.Subject;

namespace Presentation.BookView
{
    public partial class FormBooklist : Form
    {
        Book? Model = null;
        libraryContext context = new libraryContext();
        public FormBooklist()
        {
            InitializeComponent();
        }

        private void FormBooklist_Load(object sender, EventArgs e)
        {
            ShowBookList();
            ShowSubject();
        }

        private void ShowSubject()
        {
            var _list = Database.Context.Subjects.Select(p => new SubjectSearchModel { Id = p.Id, SubjectName = p.SubjectName });
            combo_Subject.DataSource = _list.ToList();
            combo_Subject.DisplayMember = "SubjectName";
            combo_Subject.ValueMember = "Id";
            combo_Subject.SelectedIndex = -1;

        }
        private void ShowBookList()
        {
            string bookName = txt_BookName.Text.Trim();
            string isbn = txt_ISBN.Text.Trim();
            int subjectId = Convert.ToInt32(combo_Subject.SelectedValue);
            var _list = Database.Context.Books.Where(p => p.BookName.Contains(bookName)
            && p.ISBN.Contains(isbn) && (p.SubjectId == subjectId || subjectId == 0))

                .Select(p => new
                {
                    p.BookName,
                    p.ISBN,
                    p.Id,
                    p.Abstract,
                    SubjectName = (p.Subject != null) ? p.Subject.SubjectName : null,
                    p.Writers

                }).ToList();
            List<BookSearchModel> books = new List<BookSearchModel>();

            foreach (var item in _list)
            {
                BookSearchModel book = new BookSearchModel
                {
                    BookName = item.BookName,
                    ISBN = item.ISBN,
                    Id = item.Id,
                    SubjectName = item.SubjectName,
                };
                foreach (var writer in item.Writers)
                {
                    book.writers += writer?.Persons?.FirstName + " " + writer?.Persons?.LastName + " - ";
                }


                books.Add(book);

            }

            Grid_BookList.DataSource = books.ToList();

            if (Grid_BookList.RowCount != 0)
            {
                Grid_BookList.Rows[0].Selected = false;
            }
        }
        //private void ShowBooks()
        //{
        //    string bookName = txt_BookName.Text.Trim();
        //    string Isbn = txt_ISBN.Text.Trim();
        //    int? subjectid= combo_Subject.SelectedValue.ToInt();

        //    var _list = DataBase.Context.Books.Where(p => p.BookName
        //    .Contains(bookName) && p.ISBN.Contains(Isbn) && (p.SubjectId==subjectid || subjectid == 0))
        //        .Select(p => new BookSearchModel 
        //        { BookName = p.BookName, Abstract = p.Abstract, ISBN = p.ISBN, Id = p.Id, SubjectName = p.Subject.SubjectName });
        //    Grid_BookList.DataSource = _list.ToList();
        //}

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            FormBook form = new FormBook(Model);
            form.ShowDialog();
            ShowBookList();
        }

        private void Grid_BookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_BookList["CelId", e.RowIndex].Value.ToInt();
            Model = Database.Context.Books.Find(id);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowBookList();
        }

        private void Add_List(object sender, EventArgs e)
        {
            FormBook Form = new FormBook();
            Form.ShowDialog();
            ShowBookList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage(); return;
            }
            if (MyMessageBox.ConfirmedMessage())
            {
                context.Books.Remove(Model);
                context.SaveChanges();
                ShowBookList();
                MyMessageBox.SuccessMessage();
            }
            return;

        }
    }
}
