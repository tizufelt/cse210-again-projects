public class Journal
    {
    public List<Entry1> _entrylist = new List<Entry1>() {
    };

    public Journal()
    {

    }
    public void Display()
    {

        _entrylist.Reverse();
        Console.Clear();
        foreach(var Entry in _entrylist){
            Entry.display();
        }
        _entrylist.Reverse();
        Console.WriteLine();
        // Console.ReadLine();
    }
    public void Loadentry(List<Entry1> entrylist)
    {
      _entrylist = entrylist;

    }

    public List<Entry1> getwrite()
    {
      return _entrylist;
    }
    
}
