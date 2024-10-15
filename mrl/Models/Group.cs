using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mrl.Models
{

    public class Group
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Required]
        [Column("group_name")]
        public string GroupName { get; set; }

        [Column("group_desc")]
        public string GroupDesc { get; set; }

        [Required]
        [Column("member_count")]
        public uint MemberCount { get; set; }
    }
}
