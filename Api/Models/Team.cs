using System.Collections.Generic;

namespace Api.Models
{
    public class Team : BaseEntity
    {       
        public string Name { get; set; }
        public string TeamShieldImage { get; set; }
        public string Initials { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string TeamSectionUrl { get; set; }        
    }
}
