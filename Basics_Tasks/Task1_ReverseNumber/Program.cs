using System;
using System.Text;

namespace Task1_ReverseNumber {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Введіть ціле число: ");
            string input = (Console.ReadLine() ?? "").Trim();

            if (!IsInteger(input)) {
                Console.WriteLine("Помилка: потрібно ввести ціле число, наприклад 12345 або -45321.");
                return;
            }

            // Знак запам'ятовуємо окремо, а цифри перевертаємо як рядок,
            // тому програма працює з числами будь-якої довжини (5 цифр і більше),
            // навіть якщо вони не поміщаються в int чи long.
            bool isNegative = input[0] == '-';
            int firstDigitIndex = (input[0] == '-' || input[0] == '+') ? 1 : 0;

            string reversed = "";
            for (int i = input.Length - 1; i >= firstDigitIndex; i--) {
                reversed += input[i];
            }

            // Прибираємо нулі на початку: 1000 -> "0001" -> "1"
            int start = 0;
            while (start < reversed.Length - 1 && reversed[start] == '0') {
                start++;
            }
            reversed = reversed.Substring(start);

            if (isNegative && reversed != "0") {
                reversed = "-" + reversed;
            }

            Console.WriteLine($"Результат: {reversed}");
        }

        // Ціле число: необов'язковий знак + або -, далі тільки цифри
        static bool IsInteger(string text) {
            if (text.Length == 0) {
                return false;
            }

            int start = (text[0] == '-' || text[0] == '+') ? 1 : 0;
            if (start == text.Length) {
                return false;
            }

            for (int i = start; i < text.Length; i++) {
                if (text[i] < '0' || text[i] > '9') {
                    return false;
                }
            }
            return true;
        }
    }
}
