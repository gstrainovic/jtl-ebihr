using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestellPosLieferInfoProLager1
{
    public int KBestellPos { get; set; }

    public int KWarenlager { get; set; }

    public byte? NTyp { get; set; }

    public int KBestellung { get; set; }

    public int NArtikelTyp { get; set; }

    public int KArtikel { get; set; }

    public decimal? FAnzahlOffen { get; set; }

    public decimal? FAnzahlZuPicken { get; set; }

    public decimal? FAnzahlReserviert { get; set; }

    public decimal? FAnzahlReserviertEigen { get; set; }

    public decimal? FAnzahlFehlbestand { get; set; }

    public decimal? FAnzahlFehlbestandEigen { get; set; }
}
