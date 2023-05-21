using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPreiskalkulationSetting
{
    public int KPreiskalkulationSetting { get; set; }

    public string CNameSetting { get; set; } = null!;

    public string? CName { get; set; }

    public string? CModus { get; set; }

    public string? CModifikator { get; set; }

    public string? CPlattform { get; set; }

    public string? CKundenGruppe { get; set; }

    public int? KShop { get; set; }

    public int? KKundenGruppe { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FWert { get; set; }

    public decimal FApamax { get; set; }

    public decimal FApamin { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? KBenutzer { get; set; }

    public byte? NPreisBis10 { get; set; }

    public byte? NPreisBis100 { get; set; }

    public byte? NPreisBis1000 { get; set; }

    public byte? NPreisBis10000 { get; set; }

    public int? KUser { get; set; }

    public int? NPlattform { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
