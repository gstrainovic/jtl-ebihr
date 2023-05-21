using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAttributSprache
{
    public int KAttribut { get; set; }

    public int KSprache { get; set; }

    public string CName { get; set; } = null!;

    public string? CWertListe { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
