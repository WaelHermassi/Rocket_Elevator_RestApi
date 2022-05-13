using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace DotNetCoreMySQL.Models
{
    public partial class Elevator
    {
        public long id { get; set; }
        public long? column_id { get; set; }
        public string? serial_number { get; set; }
        public string? model { get; set; }
        public string? status { get; set; }
        public DateTime? date_of_commissioning { get; set; }
        public DateTime? date_of_last_inspection { get; set; }
        public byte[]? certificate_of_inspection { get; set; }
        public string? information { get; set; }
        public string? notes { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string? typing { get; set; }

        // public virtual Column? column { get; set; }
    }
}
