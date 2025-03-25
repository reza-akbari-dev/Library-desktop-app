using Sec.urityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.UserView
{
    public partial class FormLogin : Form
    {
        bool isOpen = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                SignManager.Authenticate(txt_User.Text.Trim(), txt_Pass.Text.Trim());
                isOpen = false;
                Close();
            }
            catch (Exception ex)
            {
                ErrorHandler.GetError(ex);
            }

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isOpen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            isOpen = false;
            Application.Exit();
        }
    }
}
