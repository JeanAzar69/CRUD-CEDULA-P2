using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsIDs
{
    internal class BLL
    {
        private Data _data;

        public BLL() 
        {
            _data = new Data();
        }
        public Contact SaveContact(Contact contact) 
        {
            if (contact.Id == 0)
                _data.InsertContact(contact);
           // else
               // _data.UpdateContact

            return contact;
        }
    }
}
