using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelMerkmalWertKombination
{
    public int KArtikel { get; set; }

    public int KMerkmal { get; set; }

    public byte NVerwendungszweck { get; set; }

    public int KMerkmalWert { get; set; }

    public string? CName { get; set; }

    public int KSprache { get; set; }

    public string? CSprache { get; set; }

    public string? CWert { get; set; }

    public string? CSeo { get; set; }

    public string? CMetaTitle { get; set; }

    public string? CMetaKeywords { get; set; }

    public string? CMetaDescription { get; set; }

    public string? CBeschreibung { get; set; }

    public byte[]? BMerkmalBild { get; set; }

    public byte[]? BMerkmalVorschauBild { get; set; }

    public byte[]? BWertBild { get; set; }

    public byte[]? BWertVorschauBild { get; set; }

    public int NStandard { get; set; }

    public int KPlattform { get; set; }

    public long? NSort { get; set; }
}
