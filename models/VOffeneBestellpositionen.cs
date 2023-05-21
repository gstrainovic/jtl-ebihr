using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOffeneBestellpositionen
{
    public DateTime? DLieferdatum { get; set; }

    public int KArtikel { get; set; }

    public decimal? FMengeNochZuLiefern { get; set; }
}
