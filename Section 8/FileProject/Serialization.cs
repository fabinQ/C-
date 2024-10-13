using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FileProject;

public class Serialization
{
    static string getPathToFile(string playerName)
    {
        return Path.GetFullPath(Path.Combine(Path.GetDirectoryName("."), @"..\..\..\JSON", playerName + ".json"));
    }
    static Player getPlayer()
    {
        var player = new Player()
        {
            Name = "Mario",
            Level = 1,
            HealthPoint = 100,
            Statistics = new List<Statistic>()
            {
                new Statistic()
                {
                    Name = "Strength",
                    Points = 10
                },
                new Statistic()
                {
                    Name = "Intelligence",
                    Points = 100
                }

            }
        };
        return player;
    }
    public void serializationToJSON()
    {
        var player = getPlayer();
        player.Level++;

        string playerSerialized = JsonConvert.SerializeObject(player);
        string path = getPathToFile(player.Name);

        if (!Path.Exists(path))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
        }

        File.WriteAllText(path, playerSerialized);

    }
    public void serializationFromJSON()
    {
        Player mario = new Player(){Name= "Mario"};
        
        string playerSerialized = File.ReadAllText(getPathToFile(mario.Name));

        mario = JsonConvert.DeserializeObject<Player>(playerSerialized);
    }

}
