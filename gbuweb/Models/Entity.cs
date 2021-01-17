using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class Entity
    {
        public int id { get; set; }
        public string  title { get; set; }
        public string description { get; set; }
        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }
        public string photo { get; set; }
        public string type { get; set; }
        public string school { get; set; } 
        public string pdf { get; set; }
    }
}