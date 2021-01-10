using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class Faculty
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string remember_me { get; set; }
        public string status { get; set; }
        public string oauth_uid { get; set; }
        public string position { get; set; }
        public string type { get; set; }
        public string school { get; set; }
        public string qualification { get; set; }
        public string field_of_teaching { get; set; }
        public string updates { get; set; }
        public string biography { get; set; }
        public string academics { get; set; }
        public string current_course { get; set; }
        public string planned_course { get; set; }
        public string past_course { get; set; }
        public string research { get; set; }
        public string books { get; set; }
        public string patents { get; set; }
        public string journals { get; set; }
        public string conference_proceeding { get; set; }
        public string phd_students { get; set; }
        public string m_b_tech_students { get; set; }
        public string graduated_students { get; set; }
        public string research_assistants { get; set; }
        public string summer_interns { get; set; }
        public string independent_studies { get; set; }
        public string contact_information { get; set; }
        public string contact_phone_number { get; set; }
        public string contact_email { get; set; }
        public string correspondence_address { get; set; }
        public string correspondence_phone_number { get; set; }
        public string correspondence_email { get; set; }
        public string user_id { get; set; }
        public string data_id { get; set; }
    }

    public class Root
    {
        public string type { get; set; }
        public string version { get; set; }
        public string comment { get; set; }
        public string name { get; set; }
        public string database { get; set; }
        public List<Faculty> data { get; set; }
    }

    //Root myDeserializedClass = JsonConvert.DeserializeObject(myJsonResponse);
}