using System;
using System.Dynamic;

namespace Klasy;

interface IFile
{
    string FileName { get; set; }

    int Size { get; set; }

    DateTime CreatedOn { get; set; }

    abstract void CompressInterface();
}
