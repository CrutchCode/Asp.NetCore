using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _PlastSiteMVC.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string MiddleName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserPhone { get; set; }
        [Required]
        [MaxLength(30)]
        public string UserLogin { get; set; }
        [Required]
        [MaxLength(16)]
        public string UserPassword { get; set; }
    }
}
