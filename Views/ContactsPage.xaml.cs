namespace Contacts.MAUI.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        List<string> contacts = new List<string>()
       {
      "Bonevy BEBY",
      "Ketsia BEBY",
      "Gemima BEBY",
      "Jacob Elan BEBY",
      "Jeremy Moses BEBY"
       };
        listContacts.ItemsSource = contacts;
    }

    /*  private void btnEditContact_Clicked(object sender, EventArgs e)
      {
          Shell.Current.GoToAsync(nameof(EditContactPage));
      }

      private void btnAddContact_Clicked(object sender, EventArgs e)
      {
          Shell.Current.GoToAsync(nameof(AddContactPage));
      }*/
    


}