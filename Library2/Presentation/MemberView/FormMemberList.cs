using Core;
using Core.Data;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.Member;

namespace Presentation.MemberView
{
    public partial class FormMemberList : Form
    {
        libraryContext Context = Database.Context;
        public Member? Model { get; set; } = null;
        public FormMemberList()
        {
            InitializeComponent();
        }

        private void Add_Member_Click(object sender, EventArgs e)
        {
            FormMember form = new FormMember();
            form.ShowDialog();
        }

        private void FormMemberList_Load(object sender, EventArgs e)
        {
            //datePicker_FromMember.Value = new DateTime(2000, 03, 21); //set a defulte time

            DateTime defutleTime = DateTime.Now.AddYears(-5);
            datePicker_FromMember.Value = defutleTime;
            ShowMember();
        }

        private void ShowMember()
        {
            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            long nationalCode = txt_NationalCode.ToLong();
            DateTime fromDate = new DateTime(datePicker_FromMember.Value.Year, datePicker_FromMember.Value.Month, datePicker_FromMember.Value.Day, 0, 0, 0);
            DateTime toDate = new DateTime(datePicker_ToMember.Value.Year, datePicker_ToMember.Value.Month, datePicker_ToMember.Value.Day, 0, 0, 0);

            var _list = Context.Members.Where(p => p.Person.FirstName.Contains(firstName) && p.Person.LastName.Contains(lastName)
              && (p.Person.NationalCode == nationalCode || nationalCode == 0) &&
                (p.MemberDate.Date.CompareTo(fromDate) >= 0) && (p.MemberDate.Date.CompareTo(toDate) <= 0)).Select
                (member => new MemberSearchModel
                {
                    FirstName = member.Person.FirstName,
                    LastName = member.Person.LastName,
                    ProofName = member.Proof.ProofName,
                    MajorName = member.Major.MajorName,
                    MemberDate = member.MemberDate,
                    Id = member.Id,

                }).ToList();
            Grid_MemberList.DataSource = _list.ToList();

        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            FormMember form = new FormMember(Model);
            form.ShowDialog();
            ShowMember();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowMember();
        }

        private void Grid_MemberList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_MemberList["CelMId", e.RowIndex].Value.ToInt();
            Model = Context.Members.Find(id);
        }

        private void Grid_MemberList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_MemberList["CelMId", e.RowIndex].Value.ToInt();
            Model=Context.Members.Find(id);
            Close();
        }
    }
}
