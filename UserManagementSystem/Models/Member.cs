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
        public int mem_Id { set; get; }

        [Required]
        public string mem_Firstname { set; get; }

        [Required]
        public string mem_Lastname{ set; get; }
    }
}
