using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace DotNetCoreMySQL.Models
{
    public partial class Intervention
    {
        public long id { get; set; }
        public int? author { get; set; }
        public int? customer_id { get; set; }
        public int? building_id { get; set; }
        public int? battery_id { get; set; }
        public int? column_id { get; set; }
        public int? elevator_id { get; set; }
        public int? employee_id { get; set; }
        public DateTime? satart_date_and_time_intervention { get; set; }
        public DateTime? end_date_and_time_intervention { get; set; }
        public string? result { get; set; }
        public string? report { get; set; }
        public string? status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
