
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Task #1
        ShowWelcome();

        // Task #2
        ShowGreeting("Ali");
        ShowGreeting("Madina");

        // Task #3
        Console.WriteLine($"Passing score: {GetPassingScore()}");

        // Task #4
        Console.WriteLine(Add(4, 7));
        Console.WriteLine(Add(0, 5));
        Console.WriteLine(Add(-3, 3));

        // Task #5
        Console.WriteLine(CreateOrderMessage("Book", 2));
        Console.WriteLine(CreateOrderMessage("Pen", 5));

        // Task #6
        int ticketPrice = GetTicketPrice(61, true);

        if (ticketPrice == -1)
            Console.WriteLine("Invalid age");
        else if (ticketPrice == 0)
            Console.WriteLine("Free");
        else
            Console.WriteLine(ticketPrice);

        // Task #7
        if (TryDivide(17, 5, out int quotient, out int remainder))
            Console.WriteLine($"Quotient: {quotient}; Remainder: {remainder}");
        else
            Console.WriteLine("Cannot divide by zero.");

        // Task #8
        int score = 95;
        int oldScore = score;

        AddBonus(ref score, 10);
        Console.WriteLine($"Before: {oldScore}; After: {score}");

        // Task #9
        int stock = 20;
        bool success = TrySellItems(ref stock, 5);
        Console.WriteLine($"Success: {success}; Stock: {stock}");

        // Task #10
        GetNumberStats(8, 3, 5, out int min, out int middle, out int max);
        Console.WriteLine($"Min: {min}; Middle: {middle}; Max: {max}");

        // Task #11
        bool averageSuccess = TryCalculateAverage(80, 90, 100, out int average);
        Console.WriteLine($"Success: {averageSuccess}; Average: {average}");

        // Task #12
        Console.WriteLine(GetPerimeter(4));
        Console.WriteLine(GetPerimeter(3, 5));
        Console.WriteLine(GetPerimeter(3, 4, 5));

        // Task #13
        ShowStudent("Ali");
        ShowStudent("Sara", 18, 60);
        ShowStudent("Bek", 16, 59);

        // Task #14
        Console.WriteLine(CalculateTotal(5000, 3));
        Console.WriteLine(CalculateTotal(5000, 3, 2000));

        // Task #15
        RunGeometryGuru();
    }

    // Task #1
    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to C# methods!");
    }

    // Task #2
    static void ShowGreeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Task #3
    static int GetPassingScore()
    {
        return 60;
    }

    // Task #4
    static int Add(int first, int second)
    {
        return first + second;
    }

    // Task #5
    static string CreateOrderMessage(string product, int quantity)
    {
        return $"Order: {quantity} {product}";
    }

    // Task #6
    static int GetTicketPrice(int age, bool isWeekend)
    {
        if (age < 0 || age > 120)
            return -1;

        if (age < 7)
            return 0;

        int price = isWeekend ? 15000 : 10000;

        if (age > 60 && isWeekend)
            price = price * 80 / 100;

        return price;
    }

    // Task #7
    static bool TryDivide(int number, int divisor, out int quotient, out int remainder)
    {
        quotient = 0;
        remainder = 0;

        if (divisor == 0)
            return false;

        quotient = number / divisor;
        remainder = number % divisor;

        return true;
    }

    // Task #8
    static void AddBonus(ref int score, int bonus)
    {
        if (score < 0 || score > 100 || bonus < 0 || bonus > 30)
            return;

        score += bonus;

        if (score > 100)
            score = 100;
    }

    // Task #9
    static bool TrySellItems(ref int stock, int quantity)
    {
        if (stock < 0 || quantity < 0 || quantity > stock)
            return false;

        stock -= quantity;
        return true;
    }

    // Task #10
    static void GetNumberStats(
        int first,
        int second,
        int third,
        out int min,
        out int middle,
        out int max)
    {
        if (first > second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        if (first > third)
        {
            int temp = first;
            first = third;
            third = temp;
        }

        if (second > third)
        {
            int temp = second;
            second = third;
            third = temp;
        }

        min = first;
        middle = second;
        max = third;
    }

    // Task #11
    static bool TryCalculateAverage(
        int first,
        int second,
        int third,
        out int average)
    {
        average = 0;

        if (first < 0 || first > 100 ||
            second < 0 || second > 100 ||
            third < 0 || third > 100)
            return false;

        average = (first + second + third) / 3;
        return true;
    }

    // Task #12
    static int GetPerimeter(int side)
    {
        if (side < 1 || side > 1000000)
            return -1;

        return 4 * side;
    }

    static int GetPerimeter(int width, int height)
    {
        if (width < 1 || width > 1000000 ||
            height < 1 || height > 1000000)
            return -1;

        return 2 * (width + height);
    }

    static int GetPerimeter(int first, int second, int third)
    {
        if (first < 1 || first > 1000000 ||
            second < 1 || second > 1000000 ||
            third < 1 || third > 1000000)
            return -1;

        if (first + second <= third ||
            first + third <= second ||
            second + third <= first)
            return -1;

        return first + second + third;
    }

    // Task #13
    static void ShowStudent(string name)
    {
        Console.WriteLine($"Student: {name}");
    }

    static void ShowStudent(string name, int age, int score)
    {
        if (age < 0 || age > 120 || score < 0 || score > 100)
        {
            Console.WriteLine("Invalid student data.");
            return;
        }

        string result = score >= 60 ? "Passed" : "Needs practice";

        Console.WriteLine(
            $"Student: {name}; Age: {age}; Score: {score}; Result: {result}");
    }

    // Task #14
    static int CalculateTotal(int price, int quantity)
    {
        if (price < 1 || price > 1000000 ||
            quantity < 0 || quantity > 1000)
            return -1;

        return price * quantity;
    }

    static int CalculateTotal(int price, int quantity, int discount)
    {
        int total = CalculateTotal(price, quantity);

        if (total == -1 || discount < 0 || discount > total)
            return -1;

        return total - discount;
    }

    // Task #15
    static void ShowMainMenu()
    {
        Console.WriteLine("1 - Circle");
        Console.WriteLine("2 - Rectangle");
        Console.WriteLine("3 - Square");
        Console.WriteLine("0 - Exit");
    }

    static void ShowCalculationMenu()
    {
        Console.WriteLine("1 - Area");
        Console.WriteLine("2 - Perimeter");
        Console.WriteLine("0 - Back");
    }

    static double GetCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double GetCirclePerimeter(double radius)
    {
        return 2 * Math.PI * radius;
    }

    static double GetRectangleArea(double width, double height)
    {
        return width * height;
    }

    static double GetRectanglePerimeter(double width, double height)
    {
        return 2 * (width + height);
    }

    static double GetSquareArea(double side)
    {
        return side * side;
    }

    static double GetSquarePerimeter(double side)
    {
        return 4 * side;
    }

    static void RunGeometryGuru()
    {
        while (true)
        {
            ShowMainMenu();

            if (!int.TryParse(Console.ReadLine(), out int shape))
            {
                Console.WriteLine("Unknown choice.");
                continue;
            }

            if (shape == 0)
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            if (shape < 1 || shape > 3)
            {
                Console.WriteLine("Unknown choice.");
                continue;
            }

            while (true)
            {
                ShowCalculationMenu();

                if (!int.TryParse(Console.ReadLine(), out int calculation))
                {
                    Console.WriteLine("Unknown choice.");
                    continue;
                }

                if (calculation == 0)
                    break;

                if (calculation != 1 && calculation != 2)
                {
                    Console.WriteLine("Unknown choice.");
                    continue;
                }

                double result;

                if (shape == 1)
                {
                    Console.Write("Radius: ");

                    if (!double.TryParse(
                            Console.ReadLine(),
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double radius) ||
                        !double.IsFinite(radius) || radius <= 0)
                    {
                        Console.WriteLine("Invalid dimension.");
                        continue;
                    }

                    result = calculation == 1
                        ? GetCircleArea(radius)
                        : GetCirclePerimeter(radius);
                }
                else if (shape == 2)
                {
                    Console.Write("Width: ");

                    if (!double.TryParse(
                            Console.ReadLine(),
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double width) ||
                        !double.IsFinite(width) || width <= 0)
                    {
                        Console.WriteLine("Invalid dimension.");
                        continue;
                    }

                    Console.Write("Height: ");

                    if (!double.TryParse(
                            Console.ReadLine(),
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double height) ||
                        !double.IsFinite(height) || height <= 0)
                    {
                        Console.WriteLine("Invalid dimension.");
                        continue;
                    }

                    result = calculation == 1
                        ? GetRectangleArea(width, height)
                        : GetRectanglePerimeter(width, height);
                }
                else
                {
                    Console.Write("Side: ");

                    if (!double.TryParse(
                            Console.ReadLine(),
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double side) ||
                        !double.IsFinite(side) || side <= 0)
                    {
                        Console.WriteLine("Invalid dimension.");
                        continue;
                    }

                    result = calculation == 1
                        ? GetSquareArea(side)
                        : GetSquarePerimeter(side);
                }

                if (!double.IsFinite(result))
                {
                    Console.WriteLine("Invalid dimension.");
                    continue;
                }

                string operation = calculation == 1 ? "Area" : "Perimeter";

                Console.WriteLine(
                    $"{operation}: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
