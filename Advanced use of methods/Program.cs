﻿//ProcessString processString1 = TrimTo5Letters;
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

//var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//	["USA"] = "USD",
//	["India"] = "INR",
//	["Spain"] = "EUR",

//};

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

//countryToCurrencyMapping["Poland"] = "PLN";
//countryToCurrencyMapping["Poland"] = "EUR";

//foreach (var countryCurrencyPair in countryToCurrencyMapping)
//{
//	Console.WriteLine(
//		$"Country: {countryCurrencyPair.Key}, " +
//		$"currency: {countryCurrencyPair.Value}");
//}

//Console.WriteLine("Currency is Poland is " + countryToCurrencyMapping["Poland"]);

//if (countryToCurrencyMapping.ContainsKey("Italy"))
//{

//	Console.WriteLine("Currency is Italy is " + countryToCurrencyMapping["Italy"]);
//}

//Console.ReadKey();

//using System.Collections.Generic;

//var employees = new List<Employee>
//{
//	new Employee("Jake Smith", "Space Navigation", 25000),
//	new Employee("Anna Blake", "Space Navigation", 29000),
//	new Employee("Barbara Oak", "Xenobiology", 21500),
//	new Employee("Jake Smith", "Xenobiology", 22000),
//	new Employee("Damien Parker", "Machanics", 21000),
//	new Employee("Gustavo Sanchez", "Machanics", 20000),
//};

//var result = CalculateAverageSalaryPerDepartment(employees);

//Console.ReadKey();

//Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
//{
//	var employeesPerDepartments = new Dictionary<string, List<Employee>>();

//	foreach (var employee in employees)
//	{
//		if (!employeesPerDepartments.ContainsKey(employee.Department))
//		{
//			employeesPerDepartments[employee.Department] = new List<Employee>();
//		}

//		employeesPerDepartments[employee.Department].Add(employee);
//	}

//	var result = new Dictionary<string, decimal>();

//	foreach (var employeesPerDeparment in employeesPerDepartments)
//	{
//		decimal sumOfSalaries = 0;

//		foreach (var employee in employeesPerDeparment.Value)
//		{
//			sumOfSalaries += employee.MonthlySalary;
//		}

//		var average = sumOfSalaries / employeesPerDeparment.Value.Count;

//		result[employeesPerDeparment.Key] = average;
//	}

//	return result;
//}

//public class Employee
//{
//	public Employee(string name, string department, decimal monthlySalary)
//	{
//		Name = name;
//		Department = department;
//		MonthlySalary = monthlySalary;
//	}

//	public string Name { get; init; }
//	public string Department { get; init; }
//	public decimal MonthlySalary { get; init; }
//}

//var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

//Console.WriteLine(@"Select filter:
//Even
//Odd
//Positive");

//var userInput = Console.ReadLine();

//List<int> result = new NumbersFilter().FilterBy(userInput, numbers);

//Print(result);

//Console.ReadKey();

//void Print(IEnumerable<int> numbers)
//{
//	Console.WriteLine(string.Join(", ", numbers));
//}

//public class NumbersFilter
//{
//	public List<int> FilterBy(string filteringType, List<int> numbers)
//	{
//		switch (filteringType)
//		{
//			case "Even":
//				return SelectEven(numbers);
//			case "Odd":
//				return SelectOdd(numbers);
//			case "Positive":
//				return SelectPositive(numbers);
//			default:
//				throw new NotSupportedException($"{filteringType} is not a valid filter");

//		}
//	}

//	private List<int> SelectEven(List<int> numbers)
//	{
//		var result = new List<int>();

//		foreach (var number in numbers)
//		{
//			if (number % 2 == 0)
//			{
//				result.Add(number);
//			}
//		}

//		return result;
//	}

//	private List<int> SelectOdd(List<int> numbers)
//	{
//		var result = new List<int>();

//		foreach (var number in numbers)
//		{
//			if (number % 2 == 1)
//			{
//				result.Add(number);
//			}
//		}

//		return result;
//	}

//	private List<int> SelectPositive(List<int> numbers)
//	{
//		var result = new List<int>();

//		foreach (var number in numbers)
//		{
//			if (number > 0)
//			{
//				result.Add(number);
//			}
//		}

//		return result;
//	}
//}


//var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };
//var filteringStrategySelector = new FilteringStrategySelector();

//Console.WriteLine("Select filter:");
//Console.WriteLine(string.Join(Environment.NewLine, filteringStrategySelector.FilteringStrategiesNames));

//var userInput = Console.ReadLine();

//var filteringStrategy = filteringStrategySelector.Select(userInput);
//var result = new Filter().FilterBy(filteringStrategy, numbers);

//Print(result);

//var words = new[] { "zebra", "ostrich", "otter" };
//var oWords = new Filter().FilterBy(word => word.StartsWith("o"), words);

//Console.ReadKey();

//void Print(IEnumerable<int> numbers)
//{
//	Console.WriteLine(string.Join(", ", numbers));

//}

//public class FilteringStrategySelector
//{
//	private readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new Dictionary<string, Func<int, bool>>
//	{
//		["Even"] = number => number % 2 == 0,
//		["Odd"] = number => number % 2 == 1,
//		["Positive"] = number => number > 0,
//		["Negative"] = number => number < 0,
//	};

//	public IEnumerable<string> FilteringStrategiesNames => _filteringStrategies.Keys;

//	public Func<int, bool> Select(string filteringType)
//	{
//		if (!_filteringStrategies.ContainsKey(filteringType))
//		{
//			throw new NotSupportedException($"{filteringType} is not a valid filter");
//		}

//		return _filteringStrategies[filteringType];
//	}
//}


//public class Filter
//{
//	public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
//	{
//		var result = new List<T>();

//		foreach (var number in numbers)
//		{
//			if (predicate(number))
//			{
//				result.Add(number);
//			}
//		}

//		return result;
//	}
//}

var dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
	string DownloadData(string resourceId);
}



