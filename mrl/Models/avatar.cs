using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrl.Models
{
    public class avatar
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Column("userID")]
        public uint userID { get; set; }

        [Column("Location")]
        public string Location{ get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("UpdatedAt")]
        public DateTime UdpatedAt { get; set; }

        [Column("DeletedAt")]
        public DateTime DeletedAt { get; set; }
    }
}
