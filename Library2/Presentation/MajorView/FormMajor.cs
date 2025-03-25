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

namespace Presentation
{
    public partial class FormMajor : Form
    {
        libraryContext context = Database.Context;
        Major? selectedMajor=null ;
        public FormMajor()
        {
            InitializeComponent();
        }

        private void regester_Click(object sender, EventArgs e)
        {
            if (selectedMajor == null) 
            { 
            if (txt_MajerName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            Major major = new Major { MajorName = txt_MajerName.Text.Trim() };
            context.Add(major);
            }
            else
            {
               selectedMajor.MajorName=txt_MajerName.Text.Trim();
                context.Update(selectedMajor);
            }
            context.SaveChanges();
            ShowMajor();
            ClearText();
            MyMessageBox.SuccessMessage();
        }

        private void ClearText()
        {
            txt_MajerName.Text = "";
            selectedMajor=null;
            txt_MajerName.Focus();
        }

        private void FormMajor_Load(object sender, EventArgs e)
        {
            ShowMajor();
        }

        private void ShowMajor()
        {
            Grid_Major.AutoGenerateColumns = false;
            Grid_Major.DataSource = context.Majors.ToList();
            if (Grid_Major.RowCount !=0)
            {
                Grid_Major.Rows[0].Selected = false;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (selectedMajor == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if (MyMessageBox.ConfirmedMessage())
            {
                context.Remove(selectedMajor);
                context.SaveChanges();
                ClearText();
                ShowMajor();
                MyMessageBox.SuccessMessage();
            }
            return;
        }

        private void Grid_Major_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        if(e.RowIndex == 11)
            {
                return;
            }
        int id = Convert.ToInt32(Grid_Major["ColID",e.RowIndex].Value);
            selectedMajor = context.Majors.Find(id);
            if (selectedMajor != null)
            {
                txt_MajerName.Text = selectedMajor.MajorName;
            }
        }
    }
}
