using System;

namespace UserManagement.Models
{
    public class UserGroup
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string[] Groups { get; set; }
    }
}