using System;
public class ReadandLoad{
private string _fileName1 = "journal.txt";
   List<Entry1>entrylist = new List<Entry1>();
    public void writefile(List<Entry1> entrylist){
      string filename = promptfile($"what is the file name?");
      using (StreamWriter outputFile = new StreamWriter(filename))
      foreach (var entry in entrylist){
        
        outputFile.WriteLine(entry.something());

      }
    }
    public string promptfile(string promptquestion){
      Console.Write(promptquestion);
      string filename = Console.ReadLine();
      filename = "journal.txt";
      return filename;    
    }

    public List<Entry1>readFile()
    {
      string filename = promptfile($"what is the file name?");;
      string[] lines = System.IO.File.ReadAllLines(filename);
      

        foreach (string line in lines)
        {
        string[] parts = line.Split(",");
        Entry1 write = new Entry1();
        write.creatlist(parts);
        entrylist.Add(write);
        
        }
        return entrylist;

    }
}
