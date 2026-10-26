using System;
using System.Text;

namespace Task4_ReplaceChars {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine() ?? "";

            string result = "";
            for (int i = 0; i < text.Length; i++) {
                int position = i + 1; // рахуємо символи з 1, пробіли теж є символами

                // Кожен 15-й символ ділиться і на 3, і на 5, тому перевіряємо його першим
                if (position % 15 == 0) {
                    result += '?';
                } else if (position % 5 == 0) {
                    result += '9';
                } else if (position % 3 == 0) {
                    result += 'X';
                } else {
                    result += text[i];
                }
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
