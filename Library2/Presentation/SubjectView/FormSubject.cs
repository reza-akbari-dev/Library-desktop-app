using Core;
using Core.Data;
using Domain.Entities;
using Presentation.BookView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.Subject;

using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FormSubject : Form
    {
        libraryContext context = Database.Context;
        Subject? selectedSubject = null;

        public FormSubject()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (txt_SubjectName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }

            try
            {
                if (selectedSubject == null)
                {

                    Subject subject = new Subject
                    {
                        SubjectName = txt_SubjectName.Text.Trim()
                    };
                    context.Add(subject);
                }
                else
                {
                    selectedSubject.SubjectName = txt_SubjectName.Text.Trim();
                    context.Update(selectedSubject);
                }


                context.SaveChanges();
                ShowSubjec();
                ClearText();
                MyMessageBox.SuccessMessage();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

                ErrorHandler.GetError(ex);
            }


        }

        private void ClearText()
        {
            txt_SubjectName.Text = string.Empty;
            txt_SubjectName.Focus();
            selectedSubject = null;
        }

        private void ShowSubjec()
        {
            Grid_Subject.AutoGenerateColumns = false;
            Grid_Subject.DataSource = context.Subjects.Select(p => new SubjectSearchModel
            { SubjectName = p.SubjectName, Id = p.Id, BookCount = (p.Books != null) ? p.Books.Count : 0 }).ToList();
            //.Select(p => new SubjectSearchModel { SubjectName = p.SubjectName, ID = p.ID, BookCount = p.Books.Count }).ToList();
            if (Grid_Subject.RowCount != 0)
            {
                Grid_Subject.Rows[0].Selected = false;
            }
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            ShowSubjec();
        }

        private void Grid_Subject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = (Grid_Subject["CelId", e.RowIndex].Value).ToInt();
            selectedSubject = context.Subjects.Find(id);
            if (selectedSubject != null)
            {
                txt_SubjectName.Text = selectedSubject.SubjectName;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (selectedSubject == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if (MyMessageBox.ConfirmedMessage())
            {
                context.Subjects.Remove(selectedSubject);
                context.SaveChanges();
                ClearText();
                ShowSubjec();
                MyMessageBox.SuccessMessage();
            }
            return;
            
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Grid_Subject_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1) { return; }
            int id=( Grid_Subject["CelId",e.RowIndex].Value).ToInt();
            selectedSubject= context.Subjects.SingleOrDefault(p=>p.Id==id);
            if (selectedSubject != null)
            {
                BookOfSubject form = new BookOfSubject(selectedSubject);
                form.ShowDialog();
            }
          

        }
    }
}
