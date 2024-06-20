﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Dot_Net_Developer_Test.Models
{
    public class stockData
    {
        public int Id { get; set; }
        public string? date { get; set; }
        public string? trade_code { get; set; }
        public string? high { get; set; }
        public string? low { get; set; }
        public string? open { get; set; }
        public string? close { get; set; }
        public string? volume { get; set; }
    }
}
