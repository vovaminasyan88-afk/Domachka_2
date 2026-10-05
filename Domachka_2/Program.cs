//Console.WriteLine("=============================");
//Console.WriteLine("Идеальный вкусный бутерброд");
//Console.WriteLine("=============================");

//Console.WriteLine("----------:");
//Console.WriteLine("Ингриенты:");
//Console.WriteLine("-Хлеб");
//Console.WriteLine("-Клобаса - 2 штуки");
//Console.WriteLine("-сыр");

//Console.WriteLine("-------------");
//Console.WriteLine("Приготовлеие:");
//Console.WriteLine("1. Нарезать хлеб - 1 - 2 кусочка");
//Console.WriteLine("2. Нарезать колабсу 2 кусочка на один бутерброд");
//Console.WriteLine("3. Нарезать сыр 1 кусочек");
//Console.WriteLine("4. Подогреть по желанию на 30 - 40 секунд");

//Console.ReadLine();


//задание 2


//Console.WriteLine("--- Калькулятор Индекса Массы Тела (ИМТ) --- ");

//int ves = 50;
//double rost = 167.4;
//Console.WriteLine($"Ваш результат: вес: {ves} рост: {rost} ");
//Console.ReadLine();


// задание 3

Console.WriteLine("Улучшенный калькулятор");
Console.WriteLine("Введите первое число");
double firstNum = Convert.ToDouble(Console.ReadLine()); //Получаем 1 число

Console.WriteLine("Введите второе число");
double twoNum = Convert.ToDouble(Console.ReadLine()); // Получаем 2 число

Console.WriteLine("Введите оператор +, -, *, /");
string oper = Console.ReadLine();

switch (oper)
{
    case "+":
        Console.WriteLine($"Сложение:{firstNum}+{twoNum} = {firstNum + twoNum}");
        break;

    case "-":
        Console.WriteLine($"Вычитание:{firstNum}-{twoNum} = {firstNum - twoNum}");
        break;
    case "*":
        Console.WriteLine($"Сложение:{firstNum}*{twoNum} = {firstNum * twoNum}");
        break;
    case "/":
        Console.WriteLine($"Сложение:{firstNum}/{twoNum} = {firstNum / twoNum}");
        break;
    default: Console.WriteLine("Вы ввели не правильное значение"); break;
        
}









