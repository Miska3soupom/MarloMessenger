using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace mrl.Models
{
    public class GroupAndUser
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Column("group_id")]
        public uint Group_ID { get; set; }

        [Column("user_id")]
        public uint User_ID { get; set; }

        // Navigation properties
        [ForeignKey("Group_ID")]
        public virtual Group Group { get; set; }

        [ForeignKey("User_ID")]
        public virtual User User { get; set; }
    }
}
