using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example1App
{

    public partial class ContactList : Form
    {
        private Contact contact = new Contact { Email = "", Name = "", Phone = "" };
        private bool IsNew { get; set; } = true;
        private string SaveActionText { get => (IsNew ? "Create Contact" : "Update Contact"); }
        private IRepo repo = new ListMemoryRepo();
        private NewContact newContact = new NewContact();
        public ContactList()
        {
            InitializeComponent();
        }
        private void DoLoadContacts()
        {
            lstContactList.DataSource = null;
            lstContactList.DataSource = repo.ReadAll();//Db ReadAll in CRUD 
        }
        //private void OnEdit()
        //{
        //    //selected contact
        //    Contact selectedContact = (Contact)lstContactList.SelectedItem;
        //    //db read by email in CRUD
        //    this.contact = repo.ReadByEmail(selectedContact.Email);
        //    //object to UIs
        //    txtEmail.Text = contact.Email;
        //    txtName.Text = contact.Name;
        //    txtPhone.Text = contact.Phone;

        //    //edit mode out of edit & new modes
        //    IsNew = false;
        //    btnSave.Text = SaveActionText;
        //    txtEmail.Enabled = IsNew;
        //    //
        //    txtName.Focus();
        //}
        //private void DoUpdate()
        //{
        //    var result = MessageBox.Show(text: "Are you sure to update?",
        //                                 caption: "Confirm",
        //                                 buttons: MessageBoxButtons.YesNo,
        //                                 icon: MessageBoxIcon.Question);
        //    if (result != DialogResult.Yes)
        //    {
        //        return;
        //    }
        //    //UIs to object
        //    contact.Name = txtName.Text;
        //    contact.Phone = txtPhone.Text;
        //    //db update in CRUD
        //    repo.Update(contact.Email, contact);
        //    //
        //    result = MessageBox.Show(text: "Updated Successfully",
        //                             caption: "Alert",
        //                             buttons: MessageBoxButtons.OK,
        //                             icon: MessageBoxIcon.Information);
        //    //
        //    // DoLoadContacts();
        //}

        private void OnDelete()
        {
            if (lstContactList.SelectedIndex == -1)
            {
                var result_valid = MessageBox.Show(text: "Please select contact",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);
                return;
            }
            var selectedContact = (Contact)lstContactList.SelectedItem;
            //db Delete in CRUD
            repo.DeleteByEmail(selectedContact.Email);
            var result = MessageBox.Show(text: "Deleted Successfully",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);
            //refresh form 
            DoLoadContacts();
        }
        
        //private void btnEdit_Click_1(object sender, EventArgs e)
        //{
        //    OnEdit();
        //}

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            OnDelete();
        }
    }
}
