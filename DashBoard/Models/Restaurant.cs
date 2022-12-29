namespace DashBoard.Models
{
    public class Restaurant : BaseEntity
    {
        public string? Title { get; set; }
        public string? Keywords { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? StreetName { get; set; }
        public string? Phone { get; set; }
        public string? LandPhone { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Google { get; set; }
        public int? DistanceToUser { get; set; }
        public double? MedianPrice { get; set; }
        public string? Linkedin { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? Description { get; set; }

        public int? Preview { get; set; }
        public Guid? UserId { get; set; }
        public int? Date { get; set; }
        public int? Statu { get; set; }
        public int? Reviews { get; set; }
        public int? Reservation { get; set; }
        public int? Verified { get; set; }
        public string? Price { get; set; }
        public string? Featured { get; set; }
        public int? Views { get; set; }
        public string? Lat { get; set; }
        public string? Lon { get; set; } = null!;
        public int? EditDate { get; set; }
        public int? Premium { get; set; }
        public int? ViewCount { get; set; }
        public int? CommentCount { get; set; }
        public decimal? Rate { get; set; }
        public int? PopularActivities { get; set; }
        public Guid? RestaurantCategory { get; set; }

    }
}
