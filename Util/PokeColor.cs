﻿namespace BlazorAPI.Util
{
    public static class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "bug" => "#26de81",
                "dragon" => "#ffeaa7",
                "electric" => "#fed330",
                "fairy" => "#FF0069",
                "fighting" => "#30336b",
                "fire" => "#f0932b",
                "flying" => "#81ecec",
                "grass" => "#00b894",
                "ground" => "#EFB549",
                "ghost" => "#a55eea",
                "ice" => "#74b9ff",
                "normal" => "#95afc0",
                "poison" => "#9400D3",
                "psychic" => "#a29bfe",
                "rock" => "#2d3436",
                "water" => "#0190FF",
                _ => "#0190FF" // Default value if no match is found
            };

            return color; // Return the color value
        }
    }
}