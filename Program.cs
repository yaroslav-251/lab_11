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
// List<string> games = new List<string>
// {
//     "Minecraft",
//     "Terraria",
//     "Portal"
// };
// Console.Write("Введите название ещё одной игры: ");
// string newGame = Console.ReadLine();
// games.Add(newGame);
// Console.WriteLine("\nСписок игр:");

// for (int i = 0; i < games.Count; i++)
// {
//     Console.WriteLine($"{i + 1}. {games[i]}");
// }
// Dictionary<string, double> prices = new Dictionary<string, double>
// {
//     ["Minecraft"] = 1999.0,
//     ["Terraria"] = 699.0,
//     ["Portal"] = 499.0
// };
// Console.Write("\nВведите название игры, чтобы узнать её цену: ");
// string searchGame = Console.ReadLine();

// if (prices.TryGetValue(searchGame, out double price))
// {
//     Console.WriteLine($"Цена игры: {price:F2} руб.");
// }
// else
// {
//     Console.WriteLine("Такой игры нет в словаре цен.");
// }
// string genresText = "RPG,Sandbox,Action,RPG,Strategy,Action,Sandbox";
// string[] genresArray = genresText.Split(',');
// HashSet<string> genres = new HashSet<string>(genresArray);
// Console.WriteLine($"\nКоличество уникальных жанров: {genres.Count}");
// Console.Write("Введите жанр для поиска: ");
// string searchGenre = Console.ReadLine();

// if (genres.Contains(searchGenre))
// {
//     Console.WriteLine("Такой жанр есть в наборе.");
// }
// else
// {
//     Console.WriteLine("Такого жанра нет в наборе.");
// }
// List<int> p = [12, 14, 15, 12];

// Console.Write("Введите число: ");
// int k = int.Parse(Console.ReadLine());

// for (int i = p.Count - 1; i >= 0; i--)
// {
//     if (p[i] == k)
//     {
//         p.RemoveAt(i);
//     }
// }

// foreach (int r in p)
// {
//     Console.WriteLine(r);
// }
//Dictionary
// Dictionary<string, int> sklad = new Dictionary<string, int>
// {
//     ["Лопата"] = 45,
//     ["Молоток"] = 89,
//     ["Грабли"] = 350
// };
// Console.Write("Введите предмет");
// string h = Console.ReadLine();
// if (sklad.TryGetValue(h, out int kolichestvo))
// {
//     Console.WriteLine($"Количество предмета: {kolichestvo}");
// }
// else
// {
//     Console.WriteLine("Предмет не найден");
// }
//выбор коллекции

// LIST — список классов школы.
// List выбран, потому что хранит последовательность классов.
// Проверяем Contains, чтобы не добавлять дубликаты.
List<string> classes = new List<string>();

classes.Add("7А");

if (!classes.Contains("7Б"))
{
    classes.Add("7Б");
}

if (!classes.Contains("8А"))
{
    classes.Add("8А");
}

if (!classes.Contains("7А"))
{
    classes.Add("7А");
}

// DICTIONARY — класс и количество учеников
// Dictionary выбран, потому что позволяет найти количество учеников по классу
Dictionary<string, int> students = new Dictionary<string, int>
{
    ["7А"] = 25,
    ["7Б"] = 23,
    ["8А"] = 27
};

// HASHSET — уникальные школьные предметы.
// HashSet выбран, потому что автоматически хранит только уникальные значения.
HashSet<string> subjects = new HashSet<string>
{
    "Математика",
    "Русский язык",
    "История",
    "Математика",
    "Информатика"
};

// Выводим классы
Console.WriteLine("Классы школы:");

foreach (string className in classes)
{
    Console.WriteLine(className);
}

// Выводим количество учеников в каждом классе
Console.WriteLine("\nКоличество учеников:");

foreach (var student in students)
{
    Console.WriteLine($"{student.Key}: {student.Value}");
}

// Выводим уникальные предметы
Console.WriteLine("\nШкольные предметы:");

foreach (string subject in subjects)
{
    Console.WriteLine(subject);
}