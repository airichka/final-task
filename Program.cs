Console.Write("Введите через запятую элементы массива: ");
var userInput = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(userInput))
{
	var words = ParseWords(userInput);
	var wordsWhith3Chars = GetWordsWith3Chars(words);

	foreach (var word in wordsWhith3Chars)
	{
		Console.WriteLine(word);
	}
}
else
{
	Console.WriteLine("Вы ввели не верное значение");
}

IEnumerable<string> ParseWords(string userInput)
{
	return userInput.Replace(" ", string.Empty).Split(',');
}

IEnumerable<string> GetWordsWith3Chars(IEnumerable<string> strings)
{
	return strings.Where(x => x.Length <= 3);
}
