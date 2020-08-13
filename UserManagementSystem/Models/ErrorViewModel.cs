using System;

/*
 * Name: ErrorViewModel.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
