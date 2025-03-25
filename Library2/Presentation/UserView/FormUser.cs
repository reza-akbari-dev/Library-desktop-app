using Core;
using Core.Data;
using Domain.Entities;
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
using ViewModel.Role;

namespace Presentation.UserView
{
    public partial class FormUser : Form
    {
        libraryContext Context = Database.Context;
        Person? selectedPerson = null;
        User? Model = null;

        public FormUser(User? user = null)
        {
            InitializeComponent();
            Model = user;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "" || Txt_Password.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            if (Context.Users.Any(p => p.UserName == txt_UserName.Text))
            {
                MyMessageBox.ValidationErrorMessage(txt_UserName.Text + " This User is already registered");
                return;
            }
            if (Model == null)
            {
                Model = new User();
                Context.Add(Model);
            }
            Model.Person = selectedPerson;
            Model.UserName = txt_UserName.Text.Trim();
            Model.Password = Txt_Password.Text.Trim().Hash();

            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            Close();


        }

        private void Select_Person(object sender, EventArgs e)
        {
            FormPersonList form = new FormPersonList();
            form.ShowDialog();
            if (form.Model != null)
            {
                if (Context.Users.Any(p => p.PersonId == form.Model.Id))
                {
                    MyMessageBox.ValidationErrorMessage("This person is already registered as a member");
                    return;
                }
                selectedPerson = form.Model;
                lbl_SelectedpersonUser.Text = selectedPerson.FirstName + " " + selectedPerson.LastName;
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            ShowRegistredInfo();
        }

        private void ShowRegistredInfo()
        {
            if (Model != null)
            {
                selectedPerson = Model.Person;
                lbl_SelectedpersonUser.Text = selectedPerson?.FirstName + " " + selectedPerson?.LastName;
                txt_UserName.Text = Model.UserName;
            }
        }

        private void tab_ListOfRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_ListOfRole.SelectedIndex == 1 && Model == null)
            {
                tab_ListOfRole.SelectedIndex = 0;
                MyMessageBox.ValidationErrorMessage("At first select a person");
                return;
            }
            if (Model != null) //importan :if we dont write this command we have inner excption error for null reference******
            {
                ShowRoles();
            }
        }
        private void ShowRoles()
        {
            var _list = Context.Roles.Select(p => new RoleViewModel
            {
                Id = p.Id,
                RoleName = p.RoleName,
                IsSelected = Model.Roles != null && Model.Roles.Contains(p)
            }).ToList();
            Grid_User_Role.DataSource = _list;
        }
        private void Grid_User_Role_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                int roleid = Grid_User_Role["cellId", e.RowIndex].Value.ToInt();
                var role = Context.Roles.Find(roleid);

                if (Convert.ToBoolean(Grid_User_Role[2, e.RowIndex].Value))
                {
                    Model?.Roles?.Add(role);
                }
                else
                {
                    Model?.Roles?.Remove(role);
                }
                Context.SaveChanges();

            }

        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Grid_User_Role.EndEdit();
        }
    }
}
