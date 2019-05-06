using Microsoft.AspNet.Identity.EntityFramework;
using PetWorld.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetWorld.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
            
        }
    }
}