﻿namespace TalkToMeMario.Models
{
    public class PizzaOverviewViewModel
    {
        required
        public int Id
        { get; set; }
        required
        public string Name
        { get; set; }
        required
        public Decimal Price
        { get; set; }
    }
}