﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Server.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Contry { get; set; }
    }
}
