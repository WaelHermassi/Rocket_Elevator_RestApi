using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi
{
    public partial class SchemaMigration
    {
        public string Version { get; set; } = null!;
    }
}
