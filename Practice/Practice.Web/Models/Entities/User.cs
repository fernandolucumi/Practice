using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Web.Models.Entities
{
    using Microsoft.AspNetCore.Identity;
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
