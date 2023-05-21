using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tmahnung
{
    public int KMahnung { get; set; }

    public int? KRechnung { get; set; }

    public int? KKunde { get; set; }

    public string? CKurzText { get; set; }

    public string? CAnrede { get; set; }

    public string? CText { get; set; }

    public decimal FBruttoBetrag { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte? NStuffe { get; set; }

    public int? KSprache { get; set; }

    public int? KBenutzer { get; set; }

    public int? KFirma { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
