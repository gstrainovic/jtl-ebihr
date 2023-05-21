using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellPosOffen
{
    public int KBestellung { get; set; }

    public int KBestellPos { get; set; }

    public int KArtikel { get; set; }

    public int NArtikelTyp { get; set; }

    public decimal? FAnzahlOffen { get; set; }

    public decimal? FAnzahlZuPicken { get; set; }

    public decimal? FAnzahlNotwendigerBestand { get; set; }
}
