public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random;
    private int hiddenWordCount;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();
        this.random = new Random();
        this.hiddenWordCount = 0;

        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new Word(word));
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWordCount >= words.Count;
    }

    public void HideRandomWord()
    {
        int index;
        do
        {
            index = random.Next(words.Count);
        } while (words[index].Hidden);

        words[index].Hide();
        hiddenWordCount++;
    }

    public string GetHiddenText()
    {
        string hiddenText = "";
        foreach (Word word in words)
        {
            hiddenText += word.Hidden ? "______ " : word.Text + " ";
        }
        return $"{reference}: {hiddenText}";
    }
}