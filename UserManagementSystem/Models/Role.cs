using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: Role.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class Role
    {
        [Key]
        public int ro_Id { set; get; }

        [Required]
        [Display(Name = "Role name")]
        public string ro_name { set; get; }
    }
}
