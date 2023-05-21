using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSprachen
{
    public int KSprache { get; set; }

    public string? CNameEng { get; set; }

    public string? CNameDeu { get; set; }

    public string? CIso { get; set; }

    public string? CKultur { get; set; }

    public string CIso2 { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
