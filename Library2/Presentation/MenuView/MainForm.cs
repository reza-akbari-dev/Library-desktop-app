
using Domain.Entities;
using Presentation.BookView;
using Presentation.Borrow;
using Presentation.MemberView;
using Presentation.People;
using Presentation.RoleView;
using Presentation.UserView;
using Presentation.WriterView;
using Sec.urityManager;
using SecurityManager;

namespace Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Subject_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.SoftwareManagment);
                new FormSubject().ShowDialog();

            }
            catch (Exception ex)
            {
                ErrorHandler.GetError(ex);
            }
        }

        private void Major_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.SoftwareManagment);
                new FormMajor().ShowDialog(); ;

            }
            catch (Exception ex)
            {
                ErrorHandler.GetError(ex);
            }

        }

        private void FormBookList_click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.InformationManagment);
                new FormBooklist().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void People_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.InformationManagment);
                new FormPersonList().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void Writer_Click(object sender, EventArgs e)
        {

            try
            {
                AuthorizeManager.Autorize(UserActivity.InformationManagment);
                new FormWriterList().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void Timer_Now_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString();

        }

        private void Member_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.InformationManagment);
                new FormMemberList().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.BorrowManagment);
                new FormBorrowManagement().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void Role_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.SecurityManagement);
                new FormRole().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizeManager.Autorize(UserActivity.SecurityManagement);
                new FormUserList().ShowDialog();
            }
            catch (Exception ex)
            {

                ErrorHandler.GetError(ex);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
            lbl_UserName.Text = "User :" + SignManager.OnlineUser?.Person?.FirstName + " " + SignManager.OnlineUser?.Person?.LastName;
        }

        //private void MainForm_Shown(object sender, EventArgs e)
        //{
        //    if (SignManager.OnlineUser == null)
        //    {
        //        new FormLogin().ShowDialog();
        //    }

        //    lbl_UserName.Text = "User :" + SignManager.OnlineUser?.Person?.FirstName + " " + SignManager.OnlineUser?.Person?.LastName;
        //}

    }

}
