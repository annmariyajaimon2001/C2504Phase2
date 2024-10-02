using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1App
{
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }
        private Contact contact = new Contact { Email = "", Name = "", Phone = "" };
        private bool IsNew { get; set; } = true;
        private string SaveActionText { get => (IsNew ? "Create Contact" : "Update Contact"); }
        private IRepo repo = new ListMemoryRepo();

        private void DoNewContact()
        {
            //new contact object
            contact = new Contact { Name = "", Phone = "", Email = ""};
            //object to UIs
            
            txtName.Text = contact.Name;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
            //new mode out of edit & new modes
            IsNew = true;
            btnSave.Text = SaveActionText;
            txtEmail.Enabled = IsNew;
            //
            txtName.Focus();
        }
        
        private void DoCreate()
        {
            var result = MessageBox.Show(text: "Are you sure to create?",
                                         caption: "Confirm",
                                         buttons: MessageBoxButtons.YesNo,
                                         icon: MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            //UIs to object
            
            contact.Name = txtName.Text;
            contact.Phone = txtPhone.Text;
            contact.Email = txtEmail.Text;
            //db create in CRUD
            repo.Create(contact);
            //
            result = MessageBox.Show(text: "Created Successfully",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);
            //Refresh the form 1. refresh list 2. referesh form (new contact mode)
            //DoLoadContacts();
            DoNewContact();
        }

        
        
       
        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
           
            if (IsNew)
            {
                DoCreate();
            }
        }

        private void NewContact_Load(object sender, EventArgs e)
        {

            DoNewContact();
        }

        private void btnNewContact_Click_1(object sender, EventArgs e)
        {
            DoNewContact();
        }
    }
}

