using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class Recent
    {
        public int  id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        [DataType(DataType.Date)]
        public DateTime createdAt { get; set; }
        public string pdf { get; set; }

        internal static IList<Recent> getRecentNews()
        {
            var mydb = new MyDbContext();
            var data = from s in mydb.Recents select s;
            return data.ToList();
        }
    }
}