using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelBeschreibung
{
    public int KArtikel { get; set; }

    public int? KSprache { get; set; }

    public int KShop { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CKurzBeschreibung { get; set; }

    public string? CUrlPfad { get; set; }

    public string? CMetaDescription { get; set; }

    public string? CTitleTag { get; set; }

    public string? CMetaKeywords { get; set; }
}
