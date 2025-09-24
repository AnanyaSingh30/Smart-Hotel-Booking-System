namespace SmartHotelManagement.Models

{
    public class Hotel
    {
        public int Id { get;set;}
        public string? HotelName { get;set;}
        public string? Location { get;set;} 
        public int Rating { get;set;}
        public ICollection<Room>? Rooms { get; set;}
    }
}