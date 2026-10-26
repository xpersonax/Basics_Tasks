using System;
using System.Globalization;
using System.Text;

namespace Task3_ShapeArea {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Площу якої фігури обчислити?");
            Console.WriteLine("1 - Квадрат");
            Console.WriteLine("2 - Круг");
            Console.WriteLine("3 - Прямокутник");
            Console.WriteLine("4 - Трикутник");
            Console.Write("Ваш вибір (номер або назва): ");
            string choice = (Console.ReadLine() ?? "").Trim().ToLower();

            double area;
            switch (choice) {
                case "1":
                case "квадрат": {
                        double side = ReadPositiveNumber("Введіть сторону квадрата: ");
                        area = side * side;
                        break;
                    }
                case "2":
                case "круг": {
                        double radius = ReadPositiveNumber("Введіть радіус круга: ");
                        area = Math.PI * radius * radius;
                        break;
                    }
                case "3":
                case "прямокутник": {
                        double a = ReadPositiveNumber("Введіть першу сторону прямокутника: ");
                        double b = ReadPositiveNumber("Введіть другу сторону прямокутника: ");
                        area = a * b;
                        break;
                    }
                case "4":
                case "трикутник": {
                        double baseLength = ReadPositiveNumber("Введіть основу трикутника: ");
                        double height = ReadPositiveNumber("Введіть висоту трикутника: ");
                        area = baseLength * height / 2;
                        break;
                    }
                default: {
                        Console.WriteLine("Помилка: такої фігури немає в списку.");
                        return;
                    }
            }

            Console.WriteLine("Площа = " + area.ToString("0.####", CultureInfo.InvariantCulture));
        }

        // Повторює запит, доки користувач не введе додатне число.
        // Дробову частину можна писати і через крапку (2.5), і через кому (2,5).
        static double ReadPositiveNumber(string prompt) {
            while (true) {
                Console.Write(prompt);
                string input = (Console.ReadLine() ?? "").Trim().Replace(',', '.');

                double value;
                if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out value) && value > 0) {
                    return value;
                }
                Console.WriteLine("Потрібно ввести додатне число, наприклад 2.5");
            }
        }
    }
}
