using Core;
using Core.Data;
using Domain.Entity;
using Presentation.MemberView;
using Presentation.Shared;
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
using ViewModel.Shared;
using Domain.Entities;
using ViewModel.FormBorrow;

namespace Presentation.Borrow
{
    public partial class FormBorrowManagement : Form
    {
        libraryContext Context = Database.Context;
        Member? selectedMember = null;
        FormBorrow? Model = null;

        public FormBorrowManagement()
        {
            InitializeComponent();
        }

        private void Select_Member_Click(object sender, EventArgs e)
        {
            FormMemberList form = new FormMemberList();
            form.ShowDialog();
            if (form.Model != null)
            {
                selectedMember = form.Model;
                lbl_selected_member.Text = selectedMember?.Person?.FirstName + " " + selectedMember?.Person?.LastName;
                ShowBorrowListForSelectedMember();

            }
        }

        private void ShowBorrowListForSelectedMember()
        {
            var _list = selectedMember?.FormBorrows?.Select(p => new FormBorrowSearchModel
            {
                BookName = p.Book.BookName,
                Id = p.Id,
                BorrowDate = p.BorrowDate,
                NumberOfDay = p.NumberOfDay,
            }).ToList();
            Grid_FormBorrow.DataSource = _list;
        }

        private void myComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowBooksForSelectedSubject();
        }

        private void ShowBooksForSelectedSubject()
        {
            int subjectId = Convert.ToInt32(Combo_Subject.SelectedValue);
            var _list = Context.Books.Where(p => p.SubjectId == subjectId).Select(p => new comboSearchModel
            {
                Id = p.Id,
                Name = p.BookName
            }).ToList();
            Combo_SubjectsBook.DataSource = _list;
            Combo_SubjectsBook.SelectedIndex = -1;
        }

        private void FormBorrowManagement_Load(object sender, EventArgs e)
        {
            ShowSubject();
        }

        private void ShowSubject()
        {
            var _list = Context.Subjects.Select(p => new comboSearchModel
            {
                Id = p.Id,
                Name = p.SubjectName
            }).ToList();
            Combo_Subject.DataSource = _list;
            Combo_Subject.SelectedIndex = -1;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (selectedMember == null || Text_Number_Day.Text.Trim() == "" || Text_Number_Day.Text.Trim() == "0" || Combo_SubjectsBook.SelectedIndex == -1)
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            if (Model == null)
            {
                Model = new FormBorrow();
                Context.Add(Model);
            }
            Model.Member = selectedMember;
            Model.NumberOfDay = Text_Number_Day.ToInt();
            Model.BorrowDate = Picker_Date_Borrow.Value;
            Model.BookId = Convert.ToInt32(Combo_SubjectsBook.SelectedValue);

            Context.SaveChanges();
            ShowBorrowListForSelectedMember();
            ClearText();
            MyMessageBox.SuccessMessage();
        }
        private void ClearText()
        {
            //selectedMember = null;
            Text_Number_Day.Text = "";
            Picker_Date_Borrow.Value = DateTime.Now;
            Combo_SubjectsBook.DataSource = null;
            Combo_Subject.SelectedIndex = -1;
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Grid_FormBorrow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_FormBorrow["CelId", e.RowIndex].Value.ToInt();
            Model=Context.FormBorrows.SingleOrDefault(p => p.Id == id);

            if(Model != null)
            {
                if (Model.Book != null) // it is sueful for null refernce warrning
                {
                    Combo_Subject.SelectedValue = Model.Book.SubjectId;
                    ShowBooksForSelectedSubject();
                    Combo_SubjectsBook.SelectedValue = Model.BookId;
                    Picker_Date_Borrow.Value = Model.BorrowDate;
                    Text_Number_Day.Text = Model.NumberOfDay.ToString();
                    ShowBorrowListForSelectedMember();
                }
                    
            }
        }
    }
}
