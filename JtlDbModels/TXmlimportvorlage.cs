using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TXmlimportvorlage
{
    public int KXmlImportvorlage { get; set; }

    public byte NTyp { get; set; }

    public string CName { get; set; } = null!;

    public string BVorlage { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
