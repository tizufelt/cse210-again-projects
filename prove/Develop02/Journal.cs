class Journal
{
    public List<Entry> Entries;
    public PromptGenerator PromptGenerator;

    public Journal(PromptGenerator promptGenerator)
    {
        Entries = new List<Entry>();
        PromptGenerator = promptGenerator;
        
    }

   public void DisplayJournalEntries() 
   
{
    int count = 0;
    if (Entries.Count == 0) 
    {
        Console.WriteLine("No entries found.");
    }
    else
    {
        
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Entry #{++count}:"); 
            entry.DisplayEntry(); 
        }
        Console.WriteLine($"Total entries: {Entries.Count}\n"); 
    }
}

    public void CreateJournalEntry()
    {
        DateTime currentDate = DateTime.Now.Date;
        string prompt = PromptGenerator.ChoosePrompt();

        Console.WriteLine($"{prompt}");
        string response = Console.ReadLine();

        Entry entry = new Entry(currentDate.ToString("MM/dd/yyyy"), prompt, response);
        Entries.Add(entry);

        Console.WriteLine("Entry added to journal.");
    }

    public int SaveToCsv()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine("No entries to save.");
                return 0;
            }
            else
            {
                Console.WriteLine("Please enter a filename to save the journal:");
                string filename = Console.ReadLine();
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
                foreach (Entry entry in Entries)
                {
                    file.WriteLine(entry.GetEntryAsCsv());
                }
                file.Close();
                Console.WriteLine("Journal saved to " + filename + ".");
                return 1;
            }
        }

     public void LoadFromCsv()
        {
            try
            {
                Console.WriteLine("Please enter a filename to load the journal:");
                string filename = Console.ReadLine();
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                string line;
                Entries.Clear(); 
                while ((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split('|');
                    if (values.Length == 3)
                    {
                        Entry entry = new Entry(values[0], values[1], values[2]);
                        Entries.Add(entry);
                    }
                }
                file.Close();
                Console.WriteLine("Journal loaded from " + filename + ".");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading journal: " + e.Message);
            }
        }
    }

