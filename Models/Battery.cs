using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace DotNetCoreMySQL.Models
{
    public partial class Battery
    {
        public Battery()
        {
            Columns = new HashSet<Column>();
        }

        public long id { get; set; }
        [JsonIgnore]
        public long? building_id { get; set; }
        public string? status { get; set; }
        [JsonIgnore]
        public long? employee_id { get; set; }
        [JsonIgnore]
        public DateOnly? date_of_commissioning { get; set; }
        [JsonIgnore]
        public DateOnly? date_of_last_inspection { get; set; }
        [JsonIgnore]
        // public byte[]? CertificateOfOperations { get; set; }
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

        [ForeignKey("building_id")]
        public virtual Building? Building { get; set; }
        [ForeignKey("employee_id")]
        [JsonIgnore]
        public virtual Employee? Employee { get; set; }
        [JsonIgnore]
        public virtual ICollection<Column> Columns { get; set; }
    }
}
