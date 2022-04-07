using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace DotNetCoreMySQL.Models
{
    public partial class Elevator
    {
        public long Id { get; set; }
        public long? ColumnId { get; set; }
        public string? SerialNumber { get; set; }
        public string? Model { get; set; }
        public string? Status { get; set; }
        public DateOnly? DateOfCommissioning { get; set; }
        public DateOnly? DateOfLastInspection { get; set; }
        public byte[]? CertificateOfInspection { get; set; }
        public string? Information { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Typing { get; set; }

        public virtual Column? Column { get; set; }
    }
}
