using System.ComponentModel.DataAnnotations;

namespace TimesheetsAPI.Models
{
    public class Staff
    {
        public Staff(int staffId, string surname, string forename, string email)
        {
            StaffId = staffId;
            Surname = surname;
            Forename = forename;
            Email = email;
        }

        public int StaffId { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Forename { get; set; }

        public string Email { get; set; }

        public override string? ToString()
        {
            return StaffId + " " + Surname + " " + Forename;
        }
    }

}

