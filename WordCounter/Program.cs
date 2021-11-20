





var story = File.ReadAllText("pg7074.txt").ToLower()
    .Replace(".", string.Empty)
    .Replace("_", string.Empty)
    .Replace("'", string.Empty)
    .Replace(":", string.Empty)
    .Replace(",", string.Empty)
    .Replace("?", string.Empty)
    .Replace("!", string.Empty)
    .Replace(";", string.Empty)
    .Replace("(", string.Empty)
    .Replace(")", string.Empty)
    .Replace("--", " ");



var words = story.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

var wordCount = new Dictionary<string, int>();
foreach(var word in words)
{
    if (!wordCount.ContainsKey(word))
    {
        wordCount.Add(word, 0);
    }
    wordCount[word] += 1;
}

var orderedByMostPopularWord = wordCount.OrderByDescending(x => x.Value);

foreach (var keyValue in orderedByMostPopularWord)
{
    Console.WriteLine($"{keyValue.Key} = {keyValue.Value}");
}