using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        //define each property per entry
        public string Name 
        {
            get;
            set; 
        }

        public string Lastname
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        [MaxLength(10)]
        public string PhoneNumber
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public Contact()
        {
        }
    }
}
