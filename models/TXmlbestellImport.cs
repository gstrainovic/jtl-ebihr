using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TXmlbestellImport
{
    public int KXmlbestellImport { get; set; }

    public string? CText { get; set; }

    public byte? NPlattform { get; set; }

    public byte? NRechnung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
