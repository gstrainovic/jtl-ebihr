using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKategorieSprache
{
    public int KKategorie { get; set; }

    public int KSprache { get; set; }

    public int KPlattform { get; set; }

    public int KShop { get; set; }

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CUrlPfad { get; set; }

    public string? CMetaDescription { get; set; }

    public string? CTitleTag { get; set; }

    public string? CMetaKeywords { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
