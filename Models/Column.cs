using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace DotNetCoreMySQL.Models
{
    public partial class Column
    {
        public Column()
        {
            Elevators = new HashSet<Elevator>();
        }

        public long id { get; set; }
        [JsonIgnore]
        public long? battery_id { get; set; }
        [JsonIgnore]
        public string? number_of_floors_served { get; set; }
        public string? status { get; set; }
        [JsonIgnore]
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
        [ForeignKey("battery_id")]
        public virtual Battery? Battery { get; set; }
        [JsonIgnore]
        // [ForeignKey("elevator_id")]
        public virtual ICollection<Elevator> Elevators { get; set; }
    }
}
