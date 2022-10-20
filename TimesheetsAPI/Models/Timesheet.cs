namespace TimesheetsAPI.Models
{
    public class Timesheet
    {

        public Timesheet(int timesheetId, int minutesWorked, int staffId, int clientId, int locationId)
        {
            TimesheetId = timesheetId;
            MinutesWorked = minutesWorked;
            StaffId = staffId;
            ClientId = clientId;
            LocationId = locationId;
        }


        public int TimesheetId { get; set; }

        public int MinutesWorked { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

    }

}
