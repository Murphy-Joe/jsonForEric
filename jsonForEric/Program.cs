using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace jsonForEric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object
            Person eric = new Person("Eric", 24, true);

            // Convert to json
            string whatever1 = JsonSerializer.Serialize<Person>(eric);

            // Save to file.  I used an absolute path because the relative path is like bin / debug / weird stuff.
            // You'll need to specify you're own path though
            File.WriteAllText("C:/Users/Student/source/repos/jsonForEric/ericObj.json", whatever1);
            
            // print the json string just as a quick view for how it got written 
            Console.WriteLine(whatever1);


            // ****  This time with a dictionary  ***

            Dictionary<string, int> whatev = new Dictionary<string, int>() { { "eric", 3 }, { "joe", 2 }, { "david", 1 } };
            string whatever2 = JsonSerializer.Serialize<Dictionary<string, int>>(whatev); File.WriteAllText("testFile.json", whatever1);
            File.WriteAllText("C:/Users/Student/source/repos/jsonForEric/groupDict.json", whatever2);
            Console.WriteLine(whatever2);

        }
    }
}
