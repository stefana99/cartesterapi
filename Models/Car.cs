namespace CarTest.Models
{
     public class BasicCar
    {
        private string _plate;
        public int Id { get; set; }
        public string Plate { get => _plate ; set => _plate = value.ToUpper().Trim().Replace("-","").Replace(" ","");  }
        public BasicUser User { get; set; }
    }
    public class Car
    {
        private string _plate;
        public int Id { get; set; }
        public string Plate { get => _plate ; set => _plate = value.ToUpper().Trim().Replace("-","").Replace(" ","");  }
        public User User { get; set; }
    }
}