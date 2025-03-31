namespace practice_blazor.Models
{
    public class Appointment
    {
        public Guid id { get; set; }
        public string AppointmentName { get; set; }
        public string ClientName { get; set; }
        public DateTime DateAppointed { get; set; }
        public string ServiceSelected { get; set; }
        public int HoursRendered { get; set; }
        public double TotalPrice { get; set; }
        

    }
}
