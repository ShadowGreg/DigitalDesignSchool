// Задание 2.
// Напишите консольное приложение на C#, 
// которое на вход принимает большой текстовый файл 
// (например «Война и мир», можно взять отсюда http://az.lib.ru/). 
// На выходе создает текстовый файл с перечислением всех уникальных слов, 
// встречающихся в тексте, и количеством их употреблений,
// отсортированный в порядке убывания количества употреблений, например:
// d'artifice		50
// говорит		48
// значительно		30

using System.Text;
using TestTasks;

internal class Program
{
    private static void Main(string[] args)
    {
        const string FILENAME = @"C:\repository\TestTasks\Text.txt";
        var filePath = File.ReadAllText(FILENAME, Encoding.UTF8);
        if (filePath != null) //проверка на пустой файл
        {
            var textDictionary = new Lib();
            var wordDictionary = textDictionary.ConvertToDictionary(filePath);
            using var uniqueWords = new StreamWriter(@"C:\repository\TestTasks\WordsInText.txt");
            {
                foreach (var i in
                         wordDictionary.OrderByDescending(x => x.Value))
                    uniqueWords.WriteLine($"{i.Key} - {i.Value}"); //Вывод словаря в текстовый файл
            }
        }
        else
        {
            Console.WriteLine("Пустой документ");
        }
    }
}