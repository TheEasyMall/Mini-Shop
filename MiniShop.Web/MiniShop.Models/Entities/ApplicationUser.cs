﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        //[ForeignKey("Tenant")]
        //public Guid? TenantId { get; set; }
        //public Tenant? Tenant { get; set; }

        //[ForeignKey("Staff")]
        //public Guid? StaffId { get; set; }
        //public Staff? Staff { get; set; }
    }
}
