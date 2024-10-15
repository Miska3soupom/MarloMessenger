using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrl.Models
{
    public class Message
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Column("contentInfo")]
        public string contentInfo { get; set; }


    }
}
