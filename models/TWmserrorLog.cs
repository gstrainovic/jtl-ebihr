using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmserrorLog
{
    public string CName { get; set; } = null!;

    public int NProzess { get; set; }

    public string CQuelle { get; set; } = null!;

    public int NTyp { get; set; }

    public int NLevel { get; set; }

    public DateTime DTimeStamp { get; set; }

    public int? KBenutzer { get; set; }

    public string? CArbeitsPlatz { get; set; }

    public string? CValue { get; set; }

    public string? CValueBig { get; set; }

    public string? CValueXml { get; set; }

    public int? KKey1 { get; set; }

    public int? KKey2 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
