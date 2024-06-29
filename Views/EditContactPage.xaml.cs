using Contacts.MAUI.Models;

//Add this is encountered ambigious problem:
//using MesContacts = Contacts.MAUI.Models.MesContacts;

namespace Contacts.MAUI.Views;


[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private MesContacts contact;

	public EditContactPage()
	{
		InitializeComponent();
	}

   /* private void btnCancel_Clicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("..");
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }*/
    public string ContactId
    {
        set
        {
           contact = MesContactsRepository.GetContactById(int.Parse(value));
            //lblName.Text = contact.Name;
            //  lblName.Text = contact.Name;
            if (contact != null)
            {
                entryName.Text = contact.Name;
                entryEmail.Text = contact.Email;
                entryPhone.Text = contact.Phone;
                entryAddress.Text = contact.Address;
               
            }
        }
    }

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
        contact.Name = entryName.Text;
        contact.Email = entryEmail.Text;
        contact.Phone = entryPhone.Text;
        contact.Address = entryAddress.Text;

        MesContactsRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {

    }
}