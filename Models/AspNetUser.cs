
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace web_req_volcano.Models
{
    public class AspNetUser: IdentityUser
    {

       public string FirstName { get; set; }
    }
}
