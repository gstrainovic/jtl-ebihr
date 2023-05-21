using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VZulaufLagerartikel
{
    public DateTime? DLieferdatum { get; set; }

    public int KArtikel { get; set; }

    public decimal? FMengeNochZuLiefern { get; set; }

    public decimal? FAnzahlOffenGesamt { get; set; }

    public decimal FAnzahlFehlbestand { get; set; }

    public decimal? FAnzahlZulauf { get; set; }

    public long? NRowNumber { get; set; }
}
