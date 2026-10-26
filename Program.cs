// часть 1
// List<string> students = ["Иван", "Пётр", "Анна"];
// Console.WriteLine(students.Count);
// students.Add("Ярик");
// students.Remove("Иван");
// Console.WriteLine(students[0]);
// if (students.Contains("Анна"))
// {
//     Console.WriteLine("Есть");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// foreach (string i in students)
// {
//     Console.WriteLine(i);
// }
// часть 2
// Dictionary<string, double> prices = new()
// {
//     ["Хлеб"] = 45.5,
//     ["Молоко"] = 89.6
// };
// prices.Add("Кола", 79.99);
// prices.Add("Шоколадка", 52.50);
// Console.WriteLine($"Цена хлеба: {prices["Хлеб"]}");
// prices["Молоко"] = 95.56;
// if (prices.ContainsKey("Сыр"))
// {
//     Console.WriteLine("Сыр есть в словаре");
// }
// else
// {
//     Console.WriteLine("Сыра нет в словаре");
// }
// Console.Write("Введите название товара: ");
// string product = Console.ReadLine();

// if (prices.TryGetValue(product, out double price))
// {
//     Console.WriteLine($"Цена товара: {price}");
// }
// else
// {
//     Console.WriteLine("Товар не найден");
// }
// Console.WriteLine("Все товары:");

// foreach (var pair in prices)
// {
//     Console.WriteLine($"{pair.Key}: {pair.Value}");
// }
// часть 3
// string[] input = ["C#", "Git", "C#", "SQL", "Git", "C#"];
// HashSet<string> t = [];
// foreach (string r in input)
// {
//     t.Add(r);
// }
// Console.WriteLine($"Количество элементов в массиве: {input.Length}");
// Console.WriteLine($"Количество уникальных значений: {t.Count}");
// Console.Write("Введите название технологии: ");
// string search = Console.ReadLine();

// if (t.Contains(search))
// {
//     Console.WriteLine("Такая технология есть");
// }
// else
// {
//     Console.WriteLine("Такой технологии нет");
// }
