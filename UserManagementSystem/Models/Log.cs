using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: Log.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class Log
    {
        [Key]
        public int log_Id { set; get; }

        [Required]
        public string log_datetime { set; get; }
    }
}
