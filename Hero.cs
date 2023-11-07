using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace heroes
    
{
 public class Hero: IHero
 {
     public string id { get; set; }
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats { get; set; }

public void evolve(int statIncrease = 5)
{
    List<KeyValuePair<string, int>> newStats = new List<KeyValuePair<string, int>>();

    foreach (var keyValuePair in stats)
    {
        int originalValue = keyValuePair.Value;
        int increment = originalValue / 2;  // Half of the original value
        int newValue = originalValue + increment * statIncrease;

        newStats.Add(new KeyValuePair<string, int>(keyValuePair.Key, newValue));
    }

    stats = newStats; // Update the stats with the new values
}

}
}
