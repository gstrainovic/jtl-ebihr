using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseImportvorlage
{
    public int KImportVorlage { get; set; }

    public int KImportTyp { get; set; }

    public int KStandardVorlage { get; set; }

    public string? CName { get; set; }

    public byte NDateiformat { get; set; }

    public byte NSpaltenbegrenzer { get; set; }

    public int NAbZeile { get; set; }

    public byte NKopfzeile { get; set; }

    public byte NQuote { get; set; }

    public byte NEscape { get; set; }

    public string? CUebersicht { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte NDeleted { get; set; }
}
