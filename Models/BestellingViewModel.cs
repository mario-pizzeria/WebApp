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
            public double SubTotaal { get; set; }
    }
}