//ProcessString processString1 = TrimTo5Letters;
//ProcessString processString2 = ToUpper;
//Console.WriteLine(processString1("Helloooooooooooooooooooo"));
//Console.WriteLine(processString2("Helloooooooooooooooooooo"));
//Console.ReadKey();

//string TrimTo5Letters(string input)
//{
//	return input.Substring(0, 5);
//}

//string ToUpper(string input)
//{
//	return input.ToUpper();
//}

//delegate string ProcessString(string input);

//Print print1 = text => Console.WriteLine(text.ToUpper());
//Print print2 = text => Console.WriteLine(text.ToLower());
//Print multicast = print1 + print2;
//Print print4 = text => Console.WriteLine(text.Substring(0, 3));
//multicast += print4;

//multicast("Crocodile");

//Func<string, string, int> sumLengths = SumLengths;

//Console.ReadKey();

//int SumLengths(string text1, string text2)
//{
//	return text1.Length + text2.Length;
//}

//delegate void Print(string input);

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
var countryToCurrencyMapping = new Dictionary<string, string>
{
	["USA"] = "USD",
	["India"] = "INR",
	["Spain"] = "EUR",

};

//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//	{ "USA", "USD" },
//	{ "India", "INR" },
//	{ "Spain", "EUR" },

//};

//countryToCurrencyMapping.Add("USA", "USD");
//countryToCurrencyMapping.Add("India", "INR");
//countryToCurrencyMapping.Add("Spain", "EUR");
//countryToCurrencyMapping.Add("Italy", "EUR");

//Console.WriteLine("Currency is Spain is " + countryToCurrencyMapping["Spain"]);

countryToCurrencyMapping["Poland"] = "PLN";
countryToCurrencyMapping["Poland"] = "EUR";

foreach (var countryCurrencyPair in countryToCurrencyMapping)
{
	Console.WriteLine(
		$"Country: {countryCurrencyPair.Key}, " +
		$"currency: {countryCurrencyPair.Value}");
}

//Console.WriteLine("Currency is Poland is " + countryToCurrencyMapping["Poland"]);

//if (countryToCurrencyMapping.ContainsKey("Italy"))
//{

//	Console.WriteLine("Currency is Italy is " + countryToCurrencyMapping["Italy"]);
//}

Console.ReadKey();