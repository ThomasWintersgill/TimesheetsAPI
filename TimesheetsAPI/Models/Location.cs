using System.ComponentModel.DataAnnotations;

namespace TimesheetsAPI.Models
{
    public class Location
    {

        public Location(int locationID, string name, string address)
        {
            LocationID = locationID;
            Name = name;
            this.address = address;
        }

        //ef knows this is primary key as the prefix is the class name
        public int LocationID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]//nullable type so need the required annotation
        public string address { get; set; }
    }
}
