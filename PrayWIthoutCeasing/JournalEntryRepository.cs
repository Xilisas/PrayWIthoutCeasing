
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrayWIthoutCeasing
{
     class JournalEntryRepository
    {
        private const string FilePath = "journal_entries.json";
        

        public static void SaveEntries(List<JournalEntry> entries)
        {
            string json = JsonConvert.SerializeObject(entries);
            try
            {
                File.WriteAllText(FilePath, json);
                if (!File.Exists(FilePath))
                {
                    // Create the file with the specified file path
                    File.Create(FilePath).Close();
                }

                // Write the JSON data to the file
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error saving journal entries: {ex.Message}");
            }

        }
        public static List<JournalEntry> GetEntries()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<JournalEntry>>(json);
            }
            else
            {
                return new List<JournalEntry>();
            }
        }
    }
}
