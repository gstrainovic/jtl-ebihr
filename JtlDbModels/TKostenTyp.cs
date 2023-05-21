using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKostenTyp
{
    public int KKostentyp { get; set; }

    public string CKostentyp { get; set; } = null!;

    public string? CKommentar { get; set; }

    public DateTime DAenderung { get; set; }

    public DateTime DErstellt { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
