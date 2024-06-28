namespace Contacts.MAUI.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        /*  List<string> contacts = new List<string>()
         {
        "Bonevy BEBY",
        "Ketsia BEBY",
        "Gemima BEBY",
        "Jacob Elan BEBY",
        "Jeremy Moses BEBY"
         };
          listContacts.ItemsSource = contacts;*/
        List<Contact> contacts = new List<Contact>()
        {
            new Contact {Name="Bonevy BEBY",Email="bonevybeby@gmail.com"},
            new Contact {Name="Ketsia BEBY",Email="kb@gmail.com"},
            new Contact {Name="Gemima BEBY",Email="gb@gmail.com"},
            new Contact {Name="Jacob Elan BEBY",Email="jelanb@gmail.com"},
            new Contact {Name="Jeremy Moses BEBY",Email="jmb@gmail.com"}
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

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    


}