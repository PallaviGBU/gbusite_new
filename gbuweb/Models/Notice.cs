
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class Notice
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime DisplayFrom { get; set; }
        [DataType(DataType.Date)]
        public DateTime DsiaplyTill { get; set; }
        public string pdf { get; set; }
        public bool isActive { get; set; }
    }
}

