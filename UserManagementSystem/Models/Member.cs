using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: Member.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class Member
    {
        [Key]
        [Required]
        public int mem_Id { set; get; }

        [Required]
        [Display(Name = "First name")]
        public string mem_Firstname { set; get; }

        [Required]
        [Display(Name = "Last name")]
        public string mem_Lastname{ set; get; }
    }
}
