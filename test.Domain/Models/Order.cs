using test.Domain.Enum;

namespace test.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeStatus Status { get; set; }
        public int ComentId { get; set; }
        public int AutorId { get; set;}
        public int IspolnitelId { get; set; }
        public DateTime Date_Isp { get; set; }
    }
}
