﻿namespace TalkToMeMario.Models
{
    public class BestellingViewModel
    {
        required
            public int Id { get; set; }

        required
            public string KlantNaam { get; set; }

        required
            public string Status { get; set; }
        
        required
            public DateTime Tijd { get; set; }

        required
            public List<PizzaOverviewViewModel> Pizzas { get; set; } = new List<PizzaOverviewViewModel>();

        
            public double SubTotaal { get; set; }
    }
}
