using System;
using System.Text;

namespace Task2_RemoveWords {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine() ?? "";

            Console.Write("Скільки перших слів видалити (X): ");
            string xInput = (Console.ReadLine() ?? "").Trim();

            int x;
            if (!int.TryParse(xInput, out x) || x < 0) {
                Console.WriteLine("Помилка: X має бути цілим невід'ємним числом.");
                return;
            }

            // RemoveEmptyEntries — щоб кілька пробілів поспіль не рахувались як «порожні слова»
            string[] words = text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (x >= words.Length) {
                Console.WriteLine($"Результат: (порожньо — у тексті лише {words.Length} слів)");
                return;
            }

            string result = "";
            for (int i = x; i < words.Length; i++) {
                if (result.Length > 0) {
                    result += " ";
                }
                result += words[i];
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
