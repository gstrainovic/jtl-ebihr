using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAdressExportVorlage
{
    public int KAdressExportVorlage { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public byte? NStandard { get; set; }

    public string? DErstellt { get; set; }

    public string? CTrennzeichen { get; set; }

    public string? CKomma { get; set; }

    public byte? NKopfzeile { get; set; }

    public string? CPfad { get; set; }

    public byte? NZusatzzeile { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
