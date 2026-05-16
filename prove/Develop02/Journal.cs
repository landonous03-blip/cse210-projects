using System.IO;
public class Journal
{
    public List<Entry> lb_entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        lb_entries.Add(newEntry);
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in lb_entries)
            {
                outputFile.WriteLine($"{entry.lb_date}~|~{entry.lb_promptText}~|~{entry.lb_entryText}~|~{entry.lb_mood}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        lb_entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");


            Entry newEntry = new Entry();
            newEntry.lb_date = parts[0];
            newEntry.lb_promptText = parts[1];
            newEntry.lb_entryText = parts[2];
            newEntry.lb_mood = parts[3];

            lb_entries.Add(newEntry);
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in lb_entries)
        {
            entry.Display();
        }
    }
}