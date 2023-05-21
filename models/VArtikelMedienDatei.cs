using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelMedienDatei
{
    public int KMedienDatei { get; set; }

    public int KArtikel { get; set; }

    public string? CPfad { get; set; }

    public string? CUrl { get; set; }

    public string? CKategorie { get; set; }

    public string? CTyp { get; set; }

    public short? NSort { get; set; }

    public int KShop { get; set; }
}
