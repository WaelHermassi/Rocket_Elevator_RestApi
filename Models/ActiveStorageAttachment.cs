// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations.Schema;
// using System.Text.Json.Serialization;
// using System.Text.Json;

// namespace DotNetCoreMySQL.Models
// {
//     public partial class ActiveStorageAttachment
//     {
//         public long Id { get; set; }
//         public string Name { get; set; } = null!;
//         public string RecordType { get; set; } = null!;
//         public long RecordId { get; set; }
//         public long BlobId { get; set; }
//         public DateTime CreatedAt { get; set; }

//         public virtual ActiveStorageBlob Blob { get; set; } = null!;
//     }
// }
