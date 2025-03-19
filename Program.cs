namespace Motors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika s1 = new Statisztika();
            s1.ReadFromFile("motors.txt");

            Console.WriteLine($"\nÖsszes motor ára: {s1.SumPrices()} eur");

            string keresettMotor = "Pulsar NS400Z";
            Console.WriteLine($"\nTartalmazza-e a {keresettMotor} motort: {s1.Contains(keresettMotor)}");
            keresettMotor = "trabant";
            Console.WriteLine($"\nTartalmazza-e a {keresettMotor} motort: {s1.Contains(keresettMotor)}");

            Motor legregebbi = s1.Oldest();
            Console.WriteLine($"\nLegrégebbi motor: {legregebbi.Brand} {legregebbi.Name} - kiadási ébe: {legregebbi.ReleaseYear}");

            string keresettMarka = "Yamaha";
            Console.WriteLine($"\nA {keresettMarka} márkájú motorok árának sum-ja: {s1.SumBasedOnBrand(keresettMarka)} eur");
            keresettMarka = "Suzuki";
            Console.WriteLine($"\nA {keresettMarka} márkájú motorok árának sum-ja: {s1.SumBasedOnBrand(keresettMarka)} eur");

            s1.Sort();
            Console.WriteLine("\nTeljesítmény szerint csökkenő sorrendben:");
            foreach (Motor motor in s1.Motors)
            {
                Console.WriteLine($"\t{motor.Brand} {motor.Name} - {motor.Performance} lóerő");
            }
        }
    }
}
