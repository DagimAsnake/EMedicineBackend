﻿namespace EMedicineBackend.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public List<Users> ListUsers { get; set; }

        public Users user { get; set; }

        public List<Medicines> ListMedicines { get; set; }

        public Medicines medicine { get; set; }

        public List<Cart> ListCart { get; set; }

        public List<Orders> ListOrders { get; set; }

        public Orders order { get; set; }

        public List<OrderItems> ListItems { get; set; }

        public OrderItems orderItem { get; set; }
    }
}
