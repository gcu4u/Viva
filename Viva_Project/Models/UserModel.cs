using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Viva_Project.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string roll_no { get; set; }

        [MaxLength(200)]
        public string name { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
    }
}