using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPreiskalkulationLogbuchDetail
{
    public int KLogbuchDetails { get; set; }

    public int? KLogbuch { get; set; }

    public string? CArtNr { get; set; }

    public string? CPreisAlt { get; set; }

    public decimal FPreisAlt { get; set; }

    public string? CPreisNeu { get; set; }

    public decimal FPreisNeu { get; set; }

    public string? CDifferenz { get; set; }

    public string? CWaehrung { get; set; }

    public string? CEinstellungen { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
