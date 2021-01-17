using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class Etender
    {
        public string title { get; set; }
        public string file { get; set; }
        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }
    }
}