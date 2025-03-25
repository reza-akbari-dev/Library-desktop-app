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
using ViewModel.Role;

namespace Presentation.RoleView
{
    public partial class FormRole : Form
    {
        libraryContext Context = Database.Context;
        Role? Model = null;
        public FormRole()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage("enter the name of role");
                return;
            }
            Role role = new Role();
            role.RoleName = txt_RoleName.Text.Trim();
            Context.Roles.Add(role);
            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            ClearText();
            ShowRoles();
        }

        private void ClearText()
        {
            txt_RoleName.Text = "";
        }

        private void ShowRoles()
        {
            Grid_Role.DataSource = Context.Roles.Select(p => new RoleViewModel
            {
                Id = p.Id,
                RoleName = p.RoleName,
            }).ToList();

        }
        private void FormRole_Load(object sender, EventArgs e)
        {
            ShowRoles();
        }

        private void Grid_Role_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_Role["CelID", e.RowIndex].Value.ToInt();
            Model = Context.Roles.Find(id);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            Context.Roles.Remove(Model);
            Context.SaveChanges();
            ShowRoles();
            MyMessageBox.SuccessMessage();
        }

        private void New_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Grid_Role_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int id = Grid_Role["CelID", e.RowIndex].Value.ToInt();
            var role=Context.Roles.SingleOrDefault(p=>p.Id== id);
            if(role != null)
            {
                new FormRoleActivity(role).ShowDialog();

            }

        }
    }
}
