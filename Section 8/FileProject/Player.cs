using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace FileProject;

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int HealthPoint { get; set; }
    public List<Statistic> Statistics { get; set; }
}

