using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Teinstellungen
{
    public int KEinstellungen { get; set; }

    public string? CKopfPic { get; set; }

    public string? CDrucker { get; set; }

    public decimal FMwSt { get; set; }

    public int NZahlungsziel { get; set; }

    public string? CFax { get; set; }

    public string CLagerbestand { get; set; } = null!;

    public string CLootSize { get; set; } = null!;

    public string CLagerKleinerNull { get; set; } = null!;

    public string? CFaxParam { get; set; }

    public string CRechnung2x { get; set; } = null!;

    public string? CRechnungsDrucker { get; set; }

    public string? CUst { get; set; }

    public string? CEtikettDrucker { get; set; }

    public string NRunden { get; set; } = null!;

    public int NLog { get; set; }

    public string? CLogPfad { get; set; }

    public string CLieferschein2x { get; set; } = null!;

    public int NLagerAnzahl { get; set; }

    public string CBeschreibung { get; set; } = null!;

    public int? NAuftragAendern { get; set; }

    public int NSnabfragen { get; set; }
}
