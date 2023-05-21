using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvPicklistenposition
{
    public int KPicklistePos { get; set; }

    public int KPickliste { get; set; }

    public string? CPicklisteNr { get; set; }

    public decimal FAnzahl { get; set; }

    public string CBestellNr { get; set; } = null!;

    public string? CLieferscheinNr { get; set; }

    public string? CAuftragArtNr { get; set; }

    public string? CString { get; set; }

    public string? CStringStandard { get; set; }

    public int? NStatus { get; set; }

    public int NIstStueckliste { get; set; }

    public string LetzterStatusBenutzername { get; set; } = null!;

    public int KArtikel { get; set; }
}
