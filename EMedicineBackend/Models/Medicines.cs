namespace EMedicineBackend.Models
{
    public class Medicines
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Manugacturer { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public DateTime ImageUrl { get; set; }

        public int Status { get; set; }
    }
}
