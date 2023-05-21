using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AmeiseExportvorlage
{
    public int KExportVorlage { get; set; }

    public int KExportTyp { get; set; }

    public int KExportVorlageFilter { get; set; }

    public int KStandardVorlage { get; set; }

    public string? CName { get; set; }

    public byte NDateiformat { get; set; }

    public byte NSpaltenbegrenzer { get; set; }

    public byte NKopfzeile { get; set; }

    public byte NQuote { get; set; }

    public byte NEscape { get; set; }

    public string? CUebersicht { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte NDeleted { get; set; }

    public string? CExt { get; set; }

    public byte? NDezimalTrennzeichen { get; set; }

    public byte? NTausenderTrennzeichen { get; set; }

    public byte? NNachkommastellen { get; set; }

    public string CEncoding { get; set; } = null!;
}
