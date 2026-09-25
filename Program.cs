// PrintHeader();
// PrintHeader();

// Console.WriteLine("Основная часть программы");
// PrintFooter();

// PrintStudentCard("Иванов Иван", "ИСП-221", 2);
// PrintStudentCard("Смирнова Анна", "ИСП-222", 2);

// PrintPurchase("Ноутбук", 65000, true);
// PrintPurchase("Мышь", 1200, false);

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №6");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, string group, int course) {
//     Console.WriteLine($"Студент: {name}, группа {group}, курс {course}");
// }

// void PrintPurchase(string itemName, double price, bool hasDiscount) {
//     string discountLabel = hasDiscount ? " (со скидкой)" : "";
//     Console.WriteLine($"{itemName}: {price} руб.{discountLabel}");
// }

// Console.WriteLine();
// Console.WriteLine($"5 + 10 = {Add(5, 10)}");
// Console.WriteLine($"Площадь 2x2 больше площади 1x5: {CalculateRectangleArea(2, 2) > CalculateRectangleArea(1, 5)}");

// int sum = Add(15, 27);
// Console.WriteLine($"Сумма: {sum}");

// double area = CalculateRectangleArea(3.5, 4.2);
// Console.WriteLine($"Площадь прямоугольника: {area}");

// bool isAdult = IsAdult(20);
// Console.WriteLine($"Совершеннолетний: {isAdult}");

// int Add(int a, int b) {
//     return a + b;
// }

// double CalculateRectangleArea(double width, double height) {
//     return width * height;
// }

// bool IsAdult(int age) {
//     return age >= 18;
// }

// class Program {
//     static void Main() {
//         Console.WriteLine(Add(2, 3));  // вызовет первый вариант: int Add(int, int) → 5
//         Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//         Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }

//     static int Add(int a, int b) {
//         return a + b;
//     }

//     static double Add(double a, double b) {
//         return a + b;
//     }

//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }

// Console.WriteLine();
// Console.WriteLine("Методы вызывают методы");
// PrintNumberInfo(7);
// PrintNumberInfo(10);
// PrintNumberInfo(15);

// Console.WriteLine();
// Console.WriteLine("Методы + цикл");
// for (int i = 1; i <= 5; i++) {
//     PrintNumberInfo(i);
// }

// bool IsEven(int number) {
//     return number % 2 == 0;
// }

// void PrintNumberInfo(int number) {
//     string parity = IsEven(number) ? "чётное" : "нечётное";
//     Console.WriteLine($"{number} — {parity} число");
// }


// Задание 1
// Console.WriteLine($"1 m = {MetersF(1):F2} ft");
// Console.WriteLine($"5 m = {MetersF(5):F2} ft");

// Console.WriteLine($"0 C = {CelsiusC(0):F2} F");
// Console.WriteLine($"20 C = {CelsiusC(20):F2} F");

// double MetersF(double meters)
// {
//     return meters * 3.28084;
// }

// double CelsiusC(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }


// Задание 2
Console.Write("Enter password: ");
string password = Console.ReadLine();

Console.WriteLine($"Min length: {HasMinLength(password, 8)}");
Console.WriteLine($"conyains a digit: {HasDigit(password)}");
Console.WriteLine($"contains an uppercase letter: {HasUpperCase(password)}");
Console.WriteLine($"is the password valid?: {IsPasswordValid(password)}");

bool HasMinLength(string password, int minLength)
{
    return password.Length >= minLength;
}

bool HasDigit(string password)
{
    foreach (char letter in password)
    {
        if (char.IsDigit(letter))
        {
            return true;
        }
    }
    return false;
}

bool HasUpperCase(string password)
{
    foreach (char letter in password)
    {
        if (char.IsUpper(letter))
        {
            return true;
        }
    }
    return false;
}

bool IsPasswordValid(string password)
{
    return HasMinLength(password, 8) && HasDigit(password) && HasUpperCase(password);
}