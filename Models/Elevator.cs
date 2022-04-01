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
        [JsonIgnore]
        public long? column_id { get; set; }
        [JsonIgnore]
        public string? serial_number { get; set; }
        [JsonIgnore]
        public string? model { get; set; }
        public string? status { get; set; }
        [JsonIgnore]
        public DateTime? date_of_commissioning { get; set; }
        [JsonIgnore]
        public DateTime? date_of_last_inspection { get; set; }
        [JsonIgnore]
        // public byte[]? CertificateOfInspection { get; set; }
        public string? information { get; set; }
        [JsonIgnore]
        public string? notes { get; set; }
        [JsonIgnore]
        public DateTime created_at { get; set; }
        [JsonIgnore]
        public DateTime updated_at { get; set; }
        [JsonIgnore]
        public string? typing { get; set; }
        
        [JsonIgnore]
        [ForeignKey("column_id")]
        public virtual Column? Column { get; set; }
    }
}
