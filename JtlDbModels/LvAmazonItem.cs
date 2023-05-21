using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonItem
{
    public byte NStatus { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public int KUser { get; set; }

    public string? CPfUsername { get; set; }

    public string? CDummyPreis { get; set; }

    public int KPlattform { get; set; }

    public string? CValue { get; set; }

    public int KItem { get; set; }

    public string CGroupName { get; set; } = null!;

    public string? CFlatFileName { get; set; }

    public string? CProducttypeName { get; set; }

    public int KGroup { get; set; }

    public string? CDummyBarcodeType { get; set; }

    public string? CDummyBarcode { get; set; }

    public string? CDummyParentChild { get; set; }

    public string? CDummyParentSku { get; set; }

    public string? CDummyConditionType { get; set; }

    public int KArtikel { get; set; }

    public string? CErrormessage { get; set; }

    public DateTime? DErrorErstellt { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorHilfetext { get; set; }

    public string? CEan { get; set; }

    public string? CIsbn { get; set; }

    public string? CUpc { get; set; }

    public string? CAsin { get; set; }

    public string? CHan { get; set; }

    public DateTime? DLastTransmission { get; set; }
}
