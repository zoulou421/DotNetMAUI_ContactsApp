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
            new MesContacts {ContactId=1,Name="Bonevy BEBY",Email="bonevybeby@gmail.com"},
            new MesContacts {ContactId=2,Name="Ketsia BEBY",Email="kb@gmail.com"},
            new MesContacts {ContactId=3,Name="Gemima BEBY",Email="gb@gmail.com"},
            new MesContacts {ContactId=4,Name="Jacob Elan BEBY",Email="jelanb@gmail.com"},
            new MesContacts {ContactId=5,Name="Jeremy Moses BEBY",Email="jmb@gmail.com"}
        };

        public static List<MesContacts> GetContacts() => _contacts;

        public static MesContacts GetContactById(int contactId){
           // return _contacts.FirstOrDefault(x => x.ContactId == contactId);
           var contact= _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                return new MesContacts
                {
                    ContactId=contactId,
                    Email = contact.Email,
                    Name=contact.Name,
                    Address=contact.Address,
                    Phone=contact.Phone,

                };
            }
            return null;
        }

        public static void UpdateContact(int contactId, MesContacts contact)
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null)
            {
                //use AutoMapper IF you WANT.But not in this demo...

                contactToUpdate.Email = contact.Email;
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Address = contact.Address;
                contactToUpdate.Phone = contact.Phone;
                
            }
        }

        public static void AddContact(MesContacts contact)
        {
            var maxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = maxId + 1;
            _contacts.Add(contact);
        }

        public static void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
        }
        
    }
}
