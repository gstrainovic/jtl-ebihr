using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKategorie
{
    public int KKategorie { get; set; }

    public int KShop { get; set; }

    public string? CKategorieShopInet { get; set; }

    public string? CKategorieShopDelInet { get; set; }

    public bool? NInBearbeitung { get; set; }

    public int? KOberKategorie { get; set; }

    public string? CKategorieInet { get; set; }

    public string? CKategorieDelInet { get; set; }

    public string? CAktiv { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CUrlPfad { get; set; }

    public string? CTitleTag { get; set; }

    public string? CMetaKeywords { get; set; }

    public string? CMetaDescription { get; set; }

    public int KSprache { get; set; }
}
