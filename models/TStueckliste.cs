using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStueckliste
{
    public int KStueckliste { get; set; }

    public int KArtikel { get; set; }

    public decimal FAnzahl { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string CKommentar { get; set; } = null!;

    public int NSort { get; set; }

    public int KVaterArtikel { get; set; }
}
