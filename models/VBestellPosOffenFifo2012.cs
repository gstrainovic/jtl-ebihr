using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VBestellPosOffenFifo2012
{
    public int KBestellung { get; set; }

    public int KBestellPos { get; set; }

    public int KArtikel { get; set; }

    public int NArtikelTyp { get; set; }

    public decimal? FAnzahlOffen { get; set; }

    public decimal FAnzahlAufPickliste { get; set; }

    public decimal? FAnzahlVersandSperre { get; set; }

    public decimal? FAnzahlZuPicken { get; set; }

    public decimal? FAnzahlNotwendigerBestand { get; set; }

    public bool IsUmlagerung { get; set; }

    public int KWarenlager { get; set; }

    public byte? NTyp { get; set; }
}
