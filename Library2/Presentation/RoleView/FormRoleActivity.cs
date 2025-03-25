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
using ViewModel.Activity;

namespace Presentation.RoleView
{
    public partial class FormRoleActivity : Form
    {
        libraryContext Context = Database.Context;
        Role? selectedRole = null;
        public FormRoleActivity(Role role)
        {
            InitializeComponent();
            selectedRole = role;
        }

        private void FormRoleActivity_Load(object sender, EventArgs e)
        {


            var _list = Context.Activities.Select(p => new ActivitySearchModel
            {
                Id = p.Id,
                ActivityDiscription = p.ActivityDiscription,
                IsSelected = selectedRole.Activities.Contains(p)
            }).ToList();
            Grid_RoleActivity.DataSource = _list;
        }

        private void Grid_RoleActivity_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex != 2)
            {
                return;
            }
            int actid = Grid_RoleActivity["CelId", e.RowIndex].Value.ToInt();
            var activity = Context.Activities.Find(actid);
            if (activity != null)
            {
                if (Convert.ToBoolean(Grid_RoleActivity[2, e.RowIndex].Value))
                {
                    selectedRole?.Activities?.Add(activity);
                }
                else
                {
                    selectedRole?.Activities?.Remove(activity);

                }
                Context.SaveChanges();
            }
        }

        private void FormRoleActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Grid_RoleActivity.EndEdit();
        }
    }
}
