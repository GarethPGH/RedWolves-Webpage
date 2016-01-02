using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RedWolves.Models
{
    public class Canines
    {
        [Key]
        public int canineID { get; set; }

        public string canineName { get; set; }

        public string description { get; set; }

    }
}