using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Data.Hotels.Models
{
    [Table("hotels_raw")]
    public class HotelRawEntity
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("raw", TypeName = "jsonb")]
        public string Raw { get; set; } = default!;

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
    }
}