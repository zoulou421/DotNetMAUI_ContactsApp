using Contacts.MAUI.Models;

namespace Contacts.MAUI.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    /*private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }*/

    private void contactCtrl_OnSave(object sender, EventArgs e)
    {

        MesContactsRepository.AddContact(new Models.MesContacts
        {
            Name=contactCtrl.Name,
            Email=contactCtrl.Email,
            Address=contactCtrl.Address,
            Phone=contactCtrl.Phone
        });
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void contactCtrl_OnCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "ok");
    }
}