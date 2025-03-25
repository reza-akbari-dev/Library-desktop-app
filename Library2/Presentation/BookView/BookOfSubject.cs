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

namespace Presentation.BookView
{
    public partial class BookOfSubject : Form
    {
        Subject? selectedSubject = null;
        public BookOfSubject(Subject subject)
        {
            InitializeComponent();
            selectedSubject = subject;
        }

        private void BookOfSubject_Load(object sender, EventArgs e)
        {
            ShowBooks();
        }

        private void ShowBooks()
        {
            Subject_lable.Text = "Books of subject " + selectedSubject?.SubjectName;
            Grid_bookList.DataSource = selectedSubject?.Books.ToList();
        }
    }
}
