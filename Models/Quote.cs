using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreMySQL.Models
{
    public partial class Quote
    {
        public long Id { get; set; }
        public string? BuildingType { get; set; }
        public int? NumApts { get; set; }
        public int? NumFloors { get; set; }
        public int? NumBase { get; set; }
        public int? NumComp { get; set; }
        public int? NumPark { get; set; }
        public int? NumElev { get; set; }
        public int? NumCorps { get; set; }
        public int? MaxOcc { get; set; }
        public int? BHours { get; set; }
        public string? ProductLine { get; set; }
        public string? UnitPrice { get; set; }
        public string? ElevCost { get; set; }
        public string? InstallFee { get; set; }
        public string? TotalCost { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
    }
}
