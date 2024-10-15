using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mrl.Models
{
    public class Role
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Required]
        [Column("role_name")]
        public string RoleName { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("authority")]
        public int Authority { get; set; }
    }
}
