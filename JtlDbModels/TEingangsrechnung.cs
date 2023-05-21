using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEingangsrechnung
{
    public int KEingangsrechnung { get; set; }

    public int? KBenutzer { get; set; }

    public int? KLieferant { get; set; }

    public int? KAnsprechpartner { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public string? CEigeneRechnungsnummer { get; set; }

    public string? CHinweise { get; set; }

    public string? CLieferant { get; set; }

    public string? CAdresszusatz { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLandIso { get; set; }

    public string? CBundesland { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CMobil { get; set; }

    public string? CMail { get; set; }

    public byte? NStatus { get; set; }

    public byte? NDeleted { get; set; }

    public byte? NZahlungFreigegeben { get; set; }

    public DateTime? DErstellt { get; set; }

    public byte? NKumuliert { get; set; }

    public DateTime? DBezahlt { get; set; }

    public DateTime? DZahlungsziel { get; set; }

    public decimal FFremdFaktor { get; set; }

    public byte? NVerteilungsArt { get; set; }

    public DateTime? DBelegdatum { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
