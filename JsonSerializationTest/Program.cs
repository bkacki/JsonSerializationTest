using System.Text.Json;

namespace JsonSerializationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guys = new List<Guy>()
            {
                new Guy() { Name = "Borys", Clothes = new Outfit() {Top = "t-shirt", Bottom = "dżinsy"}, Hair = new HairStyle() {Color=HairColor.szare, Length=8.9f}},
                new Guy() { Name = "Wiktor", Clothes = new Outfit() {Top = "bluza", Bottom = "dzwony"}, Hair = new HairStyle() {Color=HairColor.kasztanowe, Length=3f}},
            };

            foreach (var guy in guys)
                Console.WriteLine(guy);
            Console.WriteLine();

            var jsonString = JsonSerializer.Serialize(guys);
            Console.WriteLine(jsonString);
            Console.WriteLine();

            var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
            foreach (var guy in copyOfGuys)
                Console.WriteLine("Wykonałem deserializację tego faceta: {0}", guy);
            Console.WriteLine();

            var options = new JsonSerializerOptions() { WriteIndented = true };
            var jsonStringWithOptions = JsonSerializer.Serialize(guys, options);
            Console.WriteLine(jsonStringWithOptions);
            Console.WriteLine();

            var dudes = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);
            while(dudes.Count>0)
            {
                var dude = dudes.Pop();
                Console.WriteLine($"Następny gość: {dude.Name} ma {dude.Hair}.");
            }

            Console.WriteLine();
            Console.WriteLine(JsonSerializer.Serialize(3));
            Console.WriteLine(JsonSerializer.Serialize((long)-3));
            Console.WriteLine(JsonSerializer.Serialize((byte)0));
            Console.WriteLine(JsonSerializer.Serialize(float.MaxValue));
            Console.WriteLine(JsonSerializer.Serialize(float.MinValue));
            Console.WriteLine(JsonSerializer.Serialize(true));
            Console.WriteLine(JsonSerializer.Serialize("Słoń"));
            Console.WriteLine(JsonSerializer.Serialize("Słoń".ToCharArray()));
            Console.WriteLine(JsonSerializer.Serialize("🐘"));
        }
    }
}
