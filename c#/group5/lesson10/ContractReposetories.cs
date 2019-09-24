using System;
using lesson10;

namespace lesson10{


    class ContractReposetories{
        public Contact[] contacts {set; get;}

        public ContractReposetories (Contact[] contacts){
            this.contacts = contacts; 
        }

        public void addContact(Contact contact)
        {
            Contact [] tempContacts = new Contact [contacts.Length+1];
            Array.Copy(contacts, tempContacts,contacts.Length);
            tempContacts[tempContacts.Length-1]=contact;
            contacts = tempContacts;
        }

        public void delContact(int ind){
            Contact[] tempContacts = new Contact [contacts.Length-1];
            for(int i = 0; i<contacts.Length; i++){
                if(i == ind) continue;
                if(i>ind) tempContacts[i-1]=contacts[i];
                else tempContacts[i]=contacts[i];
            }
            contacts=tempContacts;
        }
        
    }
}