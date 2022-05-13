using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace DotNetCoreMySQL.Models
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
            // Employees = new HashSet<Employee>();
        }

        public long id { get; set; }
        public string email { get; set; } = null!;
        public string encrypted_password { get; set; } = null!;
        public string? reset_passwordToken { get; set; }
        public DateTime? reset_password_sent_at { get; set; }
        public DateTime? remember_created_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        // public virtual ICollection<Employee> Employees { get; set; }
    }
}
