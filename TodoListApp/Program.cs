Console.Write("Введите help чтобы увидеть список команд. ");

string name = "Иван";
string surname = "Иванов";
int birthYear = 2003;

string[] todos = new string[2];
int todoCount = 0;

bool isRunning = true;

while (isRunning)
{
    Console.Write("Введите команду: ");
    string command = Console.ReadLine() ?? "";

    string[] parts = command.Split(' ', 2);
    string action = parts[0];

    switch (action)
    {
        case "help":
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("help - список команд");
            Console.WriteLine("profile - данные пользователя");
            Console.WriteLine("add - добавить задачу");
            Console.WriteLine("view - показать задачи");
            Console.WriteLine("exit - выход");
            break;

        case "profile":
            Console.WriteLine(
                $"{name} {surname}, {birthYear}"
            );
            break;

        case "add":
            if (parts.Length < 2 || parts[1] == "")
            {
                Console.WriteLine("Введите текст задачи.");
                break;
            }

            if (todoCount == todos.Length)
            {
                string[] newTodos = new string[todos.Length * 2];

                for (int i = 0; i < todos.Length; i++)
                {
                    newTodos[i] = todos[i];
                }

                todos = newTodos;
            }

            todos[todoCount] = parts[1];
            todoCount++;

            Console.WriteLine("Задача добавлена.");
            break;

        case "view":
            if (todoCount == 0)
            {
                Console.WriteLine("Список задач пуст.");
            }
            else
            {
                for (int i = 0; i < todoCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
            break;

        case "exit":
            isRunning = false;
            Console.WriteLine("Программа завершена.");
            break;

        default:
            Console.WriteLine("Неизвестная команда. Введите help.");
            break;
    }
}
