using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantenBestellungLieferant
{
    public int KLieferantenBestellungLieferant { get; set; }

    public int KLieferant { get; set; }

    public string? CFirma { get; set; }

    public string? CFirmenZusatz { get; set; }

    public string? CStrasse { get; set; }

    public string? CAdresszusatz { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CBundesland { get; set; }

    public string? CLandIso { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CMobil { get; set; }

    public string? CMail { get; set; }

    public string? CAnsprechpartnerAnrede { get; set; }

    public string? CAnsprechpartnerVorname { get; set; }

    public string? CAnsprechpartnerName { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
