using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPreisImportVorlage
{
    public int KPreisImportVorlage { get; set; }

    public string? CName { get; set; }

    public byte? BZeile { get; set; }

    public string? CTrennzeichen { get; set; }

    public int? KPlattform { get; set; }

    public int? KKundengruppe { get; set; }

    public byte? NVknettoberechnen { get; set; }

    public decimal FFaktor { get; set; }

    public byte? NStdvknetto { get; set; }

    public string? CIdent { get; set; }

    public int? KLieferant { get; set; }

    public string? SMapping { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
