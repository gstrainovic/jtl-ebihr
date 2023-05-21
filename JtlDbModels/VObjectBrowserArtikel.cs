using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VObjectBrowserArtikel
{
    public int KKategorieArtikel { get; set; }

    public int KKategorie { get; set; }

    public string? CKategorie { get; set; }

    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public string? CBarcode { get; set; }

    public string? CHersteller { get; set; }

    public string? CHan { get; set; }

    public string? CIsbn { get; set; }

    public string? CAsin { get; set; }

    public string? CUpc { get; set; }

    public int? KWarengruppe { get; set; }

    public string? CWarengruppe { get; set; }

    public string CSuchnummer { get; set; } = null!;
}
