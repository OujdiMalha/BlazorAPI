﻿using System.Collections.Generic;

namespace BlazorAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; } = 0;
        public string name { get; set; } = "";
        public int weight { get; set; } = 0;
        public int height { get; set; } = 0;
        public Sprites sprites { get; set; } = new Sprites();
        public List<Stat> stats { get; set; } = new List<Stat>();
        public List<Type> types { get; set; } = new List<Type>();

        // Ajoutez une propriété IsFavorite si vous souhaitez suivre l'état de favori du Pokémon
        public bool IsFavorite { get; set; } = false;
    }
}