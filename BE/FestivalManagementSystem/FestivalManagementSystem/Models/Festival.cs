using System.Diagnostics;

namespace FestivalManagementSystem.Models
{
    public class Festival
    {
        public int FestivalId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public ICollection<Guest> Guests { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
