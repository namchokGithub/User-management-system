using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: TypeAccount.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class TypeAccount
    {
        [Key]
        [Required]
        public int ta_Id { set; get; }

        [Required]
        [Display(Name = "Type account")]
        public string ta_name { set; get; }
    }
}
