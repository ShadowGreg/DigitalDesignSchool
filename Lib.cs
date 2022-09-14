namespace TestTasks;

public class Lib
{
    public Dictionary<string, int> ConvertToDictionary(string filePath)
    {
        var answerBook = new Dictionary<string, int>();
        char[] splitChars =
        {
            ' ', ',', '.', ':', '\t', '<', '>', '\n', ')', '(', '!', '?', ';', '"', ']', '[', '/', '-', '*'
        }; //разделители
        var words = filePath.Split(splitChars).Select(word => word.ToLower()).ToArray();
        //Split - разбивает строку на подстроки            
        //ToLower - возвращает строку в нижнем регистре
        var wordsItem = words.Distinct().ToArray();
        //Distinct - возвращает уникальные строки
        foreach (var item in wordsItem)
        {
            var count = 0;
            count = words.Where(word => word.Equals(item)).Count();
            //подсчет одинаковых строк
            answerBook.Add(item, count);
        }

        return answerBook;
    }
}