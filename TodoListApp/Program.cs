
Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.Write("Введите фамилию: ");
string surname = Console.ReadLine();

Console.Write("Введите год рождения: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

int age = DateTime.Now.Year - birthYear;

Console.WriteLine($"Добавлен пользователь {name} {surname}, возраст — {age}");
