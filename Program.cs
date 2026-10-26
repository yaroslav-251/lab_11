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
// итоговая задача
List<string> games = new List<string>
{
    "Minecraft",
    "Terraria",
    "Portal"
};
Console.Write("Введите название ещё одной игры: ");
string newGame = Console.ReadLine();
games.Add(newGame);
Console.WriteLine("\nСписок игр:");

for (int i = 0; i < games.Count; i++)
{
    Console.WriteLine($"{i + 1}. {games[i]}");
}
Dictionary<string, double> prices = new Dictionary<string, double>
{
    ["Minecraft"] = 1999.0,
    ["Terraria"] = 699.0,
    ["Portal"] = 499.0
};
Console.Write("\nВведите название игры, чтобы узнать её цену: ");
string searchGame = Console.ReadLine();

if (prices.TryGetValue(searchGame, out double price))
{
    Console.WriteLine($"Цена игры: {price:F2} руб.");
}
else
{
    Console.WriteLine("Такой игры нет в словаре цен.");
}
string genresText = "RPG,Sandbox,Action,RPG,Strategy,Action,Sandbox";
string[] genresArray = genresText.Split(',');
HashSet<string> genres = new HashSet<string>(genresArray);
Console.WriteLine($"\nКоличество уникальных жанров: {genres.Count}");
Console.Write("Введите жанр для поиска: ");
string searchGenre = Console.ReadLine();

if (genres.Contains(searchGenre))
{
    Console.WriteLine("Такой жанр есть в наборе.");
}
else
{
    Console.WriteLine("Такого жанра нет в наборе.");
}
