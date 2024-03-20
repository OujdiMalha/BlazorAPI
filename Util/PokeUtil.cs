namespace BlazorAPI.Util
{
    public static class PokeUtil
    {
        public const string pokeball = "icons8-pokeball-48";

        public const string Greatball = "icons8-pokeball-48";

        public const string Ultraball = "icons8-pokeball-48";

        public const string MasterBall = "icons8-pokeball-48";

        public static string GetRandomBall()
        {
            var pokeballArray = new String[] {pokeball, Greatball, Ultraball, MasterBall};

            var rand = new Random();
            string randamball = pokeballArray[rand.Next(pokeballArray.Length)];

            return randamball;
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
