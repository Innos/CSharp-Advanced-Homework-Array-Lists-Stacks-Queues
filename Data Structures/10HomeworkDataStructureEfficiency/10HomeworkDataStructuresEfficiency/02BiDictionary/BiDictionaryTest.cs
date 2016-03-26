namespace _02BiDictionary
{
    using System;

    class BiDictionaryTest
    {
        static void Main(string[] args)
        {
            var distances = new BiDictionary<string, string, int>();
            distances.Add("Sofia", "Varna", 443);
            distances.Add("Sofia", "Varna", 468);
            distances.Add("Sofia", "Varna", 490);
            distances.Add("Sofia", "Plovdiv", 145);
            distances.Add("Sofia", "Bourgas", 383);
            distances.Add("Plovdiv", "Bourgas", 253);
            distances.Add("Plovdiv", "Bourgas", 292);
            var distancesFromSofia = distances.FindByKey1("Sofia"); // [443, 468, 490, 145, 383]
            Console.WriteLine(string.Join(", ", distancesFromSofia));
            Console.WriteLine();
            var distancesToBourgas = distances.FindByKey2("Bourgas"); // [383, 253, 292]
            Console.WriteLine(string.Join(", ", distancesToBourgas));
            Console.WriteLine();
            var distancesPlovdivBourgas = distances.Find("Plovdiv", "Bourgas"); // [253, 292]
            Console.WriteLine(string.Join(", ", distancesPlovdivBourgas));
            Console.WriteLine();
            var distancesRousseVarna = distances.Find("Rousse", "Varna"); // []
            Console.WriteLine(string.Join(", ", distancesRousseVarna));
            Console.WriteLine();
            var distancesSofiaVarna = distances.Find("Sofia", "Varna"); // [443, 468, 490]
            Console.WriteLine(string.Join(", ", distancesSofiaVarna));
            Console.WriteLine();
            var result = distances.Remove("Sofia", "Varna"); // true
            Console.WriteLine(result);
            Console.WriteLine();
            var distancesFromSofiaAgain = distances.FindByKey1("Sofia"); // [145, 383]
            Console.WriteLine(string.Join(", ", distancesFromSofiaAgain));
            Console.WriteLine();
            var distancesToVarna = distances.FindByKey2("Varna"); // []
            Console.WriteLine(string.Join(", ", distancesToVarna));
            Console.WriteLine();
            var distancesSofiaVarnaAgain = distances.Find("Sofia", "Varna"); // []
            Console.WriteLine(string.Join(", ", distancesSofiaVarnaAgain));
        }
    }
}
