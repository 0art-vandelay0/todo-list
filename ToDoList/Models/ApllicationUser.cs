using Microsoft.AspNetCore.Identity;
using System;

namespace ToDoList.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Website { get; set; }
        public string Image { get; set; }
        public DateOnly Birthday { get; set; }
    }
}