using Core;
using Core.Data;
using Domain.Entities;
using Domain.Entity;
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
using ViewModel.Major;
using ViewModel.Shared;

namespace Presentation.MemberView
{
    public partial class FormMember : Form
    {
        libraryContext Context = Database.Context;
        Member? Model = null;
       Person? selectedPerson = null;
        public FormMember(Member? member=null)
        {
            InitializeComponent();
            Model=member;
        }

        private void Select_Person_Click(object sender, EventArgs e)
        {
            FormPersonList form = new FormPersonList();
            form.ShowDialog();
            if (form.Model != null)
            {
                if (Context.Members.Any(p => p.Person.Id == form.Model.Id))
                //if (Context.Members.Any(p => p.Person != null && form.Model != null && p.Person.Id == form.Model.Id))

                {
                        MyMessageBox.ValidationErrorMessage("The person is duplicate");
                    return;
                }
                selectedPerson = form.Model;
                lbl_Selectedperson.Text = selectedPerson.FirstName + " " + selectedPerson.LastName;
            }

        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            ShowProof();
            ShowMajor();
            if(Model != null)
            {
                ShowRegesteredInfo();
            }
        }

        private void ShowRegesteredInfo()
        {
            selectedPerson = Model?.Person;
            lbl_Selectedperson.Text= selectedPerson?.FirstName + " " + selectedPerson?.LastName;
            Combo_Major.SelectedValue = Model?.MajorId;
            Combo_Proof.SelectedValue = Model?.ProofId;
            //date_MemberDate.Value = Model.MemberDate;
            if (Model != null && Model?.MemberDate != null)
            {
                date_MemberDate.Value = Model.MemberDate;
            }
        }

        private void ShowMajor()
        {
            var _list = Context.Majors.Select(p => new comboSearchModel
            {
                Name = p.MajorName,
                Id = p.Id,
            }).ToList();
            Combo_Major.DataSource = _list;
            Combo_Major.SelectedIndex = -1;

        }

        private void ShowProof()
        {
            var _list = Context.Proofs.Select(p => new comboSearchModel
            {
                Name = p.ProofName,
                Id = p.Id,
            }).ToList();
            Combo_Proof.DataSource = _list;
            Combo_Proof.SelectedIndex = -1;
        }

        private void Add_Member_Click(object sender, EventArgs e)
        {
            if (selectedPerson == null)
            {
                MyMessageBox.ValidationErrorMessage("select the person");
                return;
            }
            if (Combo_Proof.SelectedIndex== -1)
            {
                MyMessageBox.SelectionErrorMessage("select the degree");
                return;
            }
            if (Model == null)
            {
               Model = new Member();
                Context.Members.Add(Model);
            }
            
            //Model.PresonId = selectedPerson.Id;
            Model.Person = selectedPerson;
            Model.ProofId =Convert.ToInt32( Combo_Proof.SelectedValue);
            Model.MajorId = Combo_Major.SelectedIndex == -1 ? -1 : Convert.ToInt32(Combo_Major.SelectedValue);
            Model.MemberDate = date_MemberDate.Value;
            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            Close();

        }
    }
}
