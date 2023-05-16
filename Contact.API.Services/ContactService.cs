using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return id == 1 
            ?  (new ContactDTO()
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "ZEREN"

            })
            : new ContactDTO() { FirstName = " ", LastName = " ", Id = 1 };
        }
    }
}
