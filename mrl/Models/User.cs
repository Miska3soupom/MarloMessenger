using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mrl.Models
{

    public class User
    {
        [Key]
        [Column("id")]
        public uint ID { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("patronymic")]
        public string Patronymic { get; set; }

        
        [Column("login")]
        public string Login { get; set; }

        
        [Column("hashed_password")]
        public string HashedPassword { get; set; }

        [Required]
        [Column("is_user_deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Column("wiki_auth")]
        public bool WikiAuth { get; set; } = false;

        [Required]
        [Column("cloud_auth")]
        public bool CloudAuth { get; set; } = false;

        [Required]
        [Column("jira_auth")]
        public bool JiraAuth { get; set; } = false;

    }
}
