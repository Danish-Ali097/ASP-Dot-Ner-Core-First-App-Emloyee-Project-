using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Ner_Core_First_App__Emloyee_Project_.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
