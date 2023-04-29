
class Entry {
    public string prompt;
    public string response;
    private string _date;

    public Entry(string date, string prompt, string response) {
        _date = date;
        this.prompt = prompt;
        this.response = response;
    }

    public void DisplayEntry() {
        Console.WriteLine($"{_date}: {prompt}\n{response}\n");
    }

    public string GetEntryAsCsv() {
        return $"{_date}|{prompt}|{response}";
    }
}