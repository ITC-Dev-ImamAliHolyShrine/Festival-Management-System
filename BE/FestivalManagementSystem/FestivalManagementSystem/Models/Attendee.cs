namespace FestivalManagementSystem.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Feedback { get; set; }
        public int FestivalId { get; set; }
        public Festival Festival { get; set; }
    }
}
