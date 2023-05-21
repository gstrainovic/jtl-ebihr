using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellPosLieferInfoProLager
{
    public int KBestellPos { get; set; }

    public int KWarenlager { get; set; }

    public int KBestellung { get; set; }

    public int KArtikel { get; set; }

    public decimal? FAnzahlOffen { get; set; }

    public decimal? FAnzahlZuPicken { get; set; }

    public decimal? FAnzahlReserviert { get; set; }

    public decimal? FAnzahlReserviertEigen { get; set; }

    public decimal? FAnzahlFehlbestand { get; set; }

    public decimal? FAnzahlFehlbestandEigen { get; set; }
}
