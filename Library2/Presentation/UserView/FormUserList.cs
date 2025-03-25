using Core;
using Core.Data;
using Domain.Entities;
using Presentation.MemberView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.User;

namespace Presentation.UserView
{
    public partial class FormUserList : Form
    {
        libraryContext Context = Database.Context;
        public User? Model { get; set; } = null;
        public FormUserList()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new FormUser().ShowDialog();
            ShowUser();

        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void ShowUser()
        {
            string userName = txt_UserName.Text;
            var _list = Context.Users.Where(p => p.UserName.Contains(userName)).Select(p => new UserSearchModel
            {
                Id = p.Id,
                FirstName = p.Person.FirstName,
                LastName = p.Person.LastName,
                UserName = p.UserName
            }).ToList();
            Grid_User.DataSource = _list;
        }

        private void Grid_User_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_User["ColId", e.RowIndex].Value.ToInt();
            Model = Context.Users.SingleOrDefault(p => p.Id == id);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.ValidationErrorMessage("Select one member");
                return;
            }
            new FormUser(Model).ShowDialog();
            ShowUser();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowUser();
        }
    }
}
