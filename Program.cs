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
string text = "Буря мглою, бурю кроет, буря по морю идёт, бурю веет маленький критин! То как зверь она завоекет: -УУУ! То заплачет как дитя!";
char[] separator = { ' ', ',', '.', ':', '\t', '<', '>', '\n', ')', '(', '!', '?', ';', '"', ']', '[', '/', '-' };//separators
string[] splitArray = text.Split(separator).Select(word => word.ToLower()).ToArray();
List<WordsCount> wordsList = new List<WordsCount>();
Print(wordsList);

void ReadFile(string path)
{

}
void Print(List<WordsCount> printWordsList)
{
    printWordsList.ForEach(p => Console.WriteLine($"{p.word} -> count: {p.count}"));
}
class WordsCount
{
    public string? word { get; set; }
    public int count { get; set; }

}