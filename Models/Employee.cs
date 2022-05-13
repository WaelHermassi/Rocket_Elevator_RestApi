using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace DotNetCoreMySQL.Models
{
    public partial class Employee
    {
        public Employee()
        {
            batteries = new HashSet<Battery>();
        }

        public long id { get; set; }
        public string? title { get; set; }
        // public long? user_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string? email { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        // public virtual User? users { get; set; }
        public virtual ICollection<Battery> batteries { get; set; }
    }
}
