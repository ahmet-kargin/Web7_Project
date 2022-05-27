using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Identity
{
    public class User : IdentityUser
    {
        //Hazır Tablolar yaratıldı üzerine ek olarak user tablosunda bu alanların olmasını da istediğimizi belirtelim.
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
