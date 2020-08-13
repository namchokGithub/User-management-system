using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: LogAccount.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class LogAccount
    {
        [Key]
        public int la_Id { set; get; }

        [ForeignKey("Account")]
        [Required]
        public int la_acc_Id { set; get; }
        
        [ForeignKey("Log")]
        [Required]
        public int la_log_Id { set; get; }
    }
}
