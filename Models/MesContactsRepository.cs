using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.MAUI.Models
{
    public static class MesContactsRepository
    {
        public static List<MesContacts> _contacts = new List<MesContacts>()
        {
            new MesContacts {Name="Bonevy BEBY",Email="bonevybeby@gmail.com"},
            new MesContacts {Name="Ketsia BEBY",Email="kb@gmail.com"},
            new MesContacts {Name="Gemima BEBY",Email="gb@gmail.com"},
            new MesContacts {Name="Jacob Elan BEBY",Email="jelanb@gmail.com"},
            new MesContacts {Name="Jeremy Moses BEBY",Email="jmb@gmail.com"}
        };

        public static List<MesContacts> GetContacts() => _contacts;

        public static MesContacts GetContactById(int contactId){
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
        
    }
}
