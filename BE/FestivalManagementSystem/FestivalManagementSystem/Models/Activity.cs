namespace FestivalManagementSystem.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FestivalId { get; set; }
        public Festival Festival { get; set; }
    }
}
