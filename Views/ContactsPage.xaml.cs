using Contacts.MAUI.Models;
using System.Collections.ObjectModel;

// in case you encounter DUPLICATE,[like MesContacts already exists] just precise this:
//using MesContacts = Contacts.MAUI.Models.MesContacts;

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
        // List <Contact> contacts=ContactRepository.GetContacts();
       // List<MesContacts> contacts = MesContactsRepository.GetContacts();

       // listContacts.ItemsSource = contacts;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //List<MesContacts> contacts = MesContactsRepository.GetContacts(); improved as follows:
        var contacts =new ObservableCollection<MesContacts>( MesContactsRepository.GetContacts());
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

    /*public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }*/

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(listContacts.SelectedItem!=null)
        {
            // DisplayAlert("test", "message", "ok");
            // await Shell.Current.GoToAsync(nameof(EditContactPage));
            await Shell.Current.GoToAsync(
            $"{nameof(EditContactPage)}?Id={((MesContacts)listContacts.SelectedItem).ContactId}");

        }
       
       
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}