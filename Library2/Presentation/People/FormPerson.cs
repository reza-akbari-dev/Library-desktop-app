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
using Core.Data.Configuration;
using Core.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing.Imaging;
using System.Security.Policy;
using Domain.Entity;
using ViewModel.Communications;
using Core;

namespace Presentation.People
{

    public partial class FormPerson : Form
    {
        Person? Model = null;

        libraryContext Context = Database.Context;

        public FormPerson(Person? person = null)
        {

            InitializeComponent();
            Model = person;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                Model = new Person();
                Context.Add(Model);
            }
            else
            {
                Context.Update(Model);
            }

            Model.FirstName = txt_FristName.Text.Trim();
            Model.LastName = txt_LastName.Text.Trim();
            Model.NationalCode = txt_NationalCode.ToLong();
            Context.SaveChanges();
            if (pic_Person.Image != null)
            {
                MemoryStream memory = new MemoryStream();
                pic_Person.Image.Save(memory, ImageFormat.Jpeg);
                Model.PersonPicture = new PersonPicture();
                Model.PersonPicture.Picture = memory.GetBuffer();
                if (Model.PersonPicture.Picture.Length > 20000)
                {
                    MyMessageBox.ValidationErrorMessage("The picture size must bee undre 2 KB");
                    return;
                }
                Context.SaveChanges();
            }

            else
            {
                Model.PersonPicture = null;
                Context.SaveChanges();
            }
            ClearText();
            MyMessageBox.SuccessMessage();
            Close();
        }

        private void ClearText()
        {
            txt_FristName.Text = "";
            txt_LastName.Text = "";
            txt_NationalCode.Text = "";
            Close();
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            if (Model != null)
            {
                ShowRigesteredInfo();
                ShowComunication();

            }
        }
        private void ShowRigesteredInfo()
        {
            txt_FristName.Text = Model?.FirstName;
            txt_LastName.Text = Model?.LastName;
            txt_NationalCode.Text = Model?.NationalCode.ToString();

            if (Model?.PersonPicture != null && Model.PersonPicture.Picture != null)
            {
                MemoryStream memory = new MemoryStream(Model.PersonPicture.Picture);
                pic_Person.Image = Image.FromStream(memory);
            }

        }
        private void Select_Pic(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pic_Person.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void Remove_pic_Click(object sender, EventArgs e)
        {
            pic_Person.Image = null;
            if (Model?.PersonPicture != null)
            {
                Model.PersonPicture.Picture = null;
            }
            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
        }
        #region Communication
        private void tab_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Person.SelectedIndex == 1 && Model == null)
            {
                tab_Person.SelectedIndex = 0;
                MyMessageBox.ValidationErrorMessage("Inter person Info");
                return;
            }
            ShowCommunicationType();
        }
        private void ShowCommunicationType()
        {
            var _list = Context.CommunicationTypes.Select(p => new CommunicationTypeSearch
            {
                CommunicationTypeName = p.CommunicationTypeName,
                Id = p.Id,
            }).ToList();
            combo_communicationType.DataSource = _list;
            combo_communicationType.DisplayMember = "CommunicationTypeName";
            combo_communicationType.ValueMember = "Id";
            combo_communicationType.SelectedIndex = -1;
        }
        private void Add_Communication_Click(object sender, EventArgs e)
        {

            if (combo_communicationType.SelectedIndex == -1 || txt_Value.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage("Inter the Info");
                return;
            }
            if (Model != null)
            {
                Model.Communications.Add(new Communication
                {
                    CommunicationTypeId = Convert.ToInt32(combo_communicationType.SelectedValue),
                    Value = txt_Value.Text.Trim()
                });
            }
            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            ShowComunication();
        }
        private void ShowComunication()
        {
            var _list = Model?.Communications?.Select(p => new CommunicationSearch
            {
                CommunicationTypeName = p.CommunicationTypes?.CommunicationTypeName,
                Id = p.Id,
                Value = p.Value,
            }).ToList();
            Grid_Communication.DataSource = _list;
            //var _list = Context.Communications.Where(k => k.Id == Model.Id).Select(p => new CommunicationSearch
            //{
            //    CommunicationTypeName = p.CommunicationTypes.CommunicationTypeName,
            //    Id = p.Id,
            //    Value = p.Value,
            //}).ToList();
            //Grid_Communication.DataSource = _list;
        }
        #endregion Communication



        private void txt_NationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block input if it's not a number or a control key.
            }
        }
    }
}
