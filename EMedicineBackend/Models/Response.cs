﻿namespace EMedicineBackend.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public List<Users> listUsers { get; set; }

        public Users user { get; set; }
    }
}
