using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TXmlgutschriftImport
{
    public int KXmlgutschriftImport { get; set; }

    public string? CText { get; set; }

    public byte? NPlattform { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
