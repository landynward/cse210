class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}\n";
    }

    public string Serialize()
    {
        return $"{Prompt},{Response},{Date:yyyy-MM-dd}";
    }

    public static Entry Deserialize(string line)
    {
        string[] parts = line.Split(',');
        if (parts.Length != 3)
            throw new ArgumentException("Invalid format for Entry serialization");

        string prompt = parts[0];
        string response = parts[1];
        DateTime date = DateTime.Parse(parts[2]);
        return new Entry(prompt, response, date);
    }
}