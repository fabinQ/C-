using System;
using System.Dynamic;

namespace Klasy;

public class File
{
    public string FileName { get; set; }

    public int Size { get; set; }

    public DateTime CreatedOn { get; set; }

    private string PrivateProp {get; set;}
    protected string ProtectedProp {get; set;}
}
