using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreMySQL.Models
{
    public partial class BuildingDetail
    {
        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public string? InformationKey { get; set; }
        public string? Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Building? Building { get; set; }
    }
}
