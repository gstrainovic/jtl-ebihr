using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VProduct2
{
    public int KProduct { get; set; }

    public string? CImageHash { get; set; }

    public string? CImageSource { get; set; }

    public string? CName { get; set; }

    public string? CKurzBeschreibung { get; set; }

    public int? NSort { get; set; }

    public decimal FPrice { get; set; }

    public decimal FPurchasingPrice { get; set; }

    public string Discount { get; set; } = null!;

    public string TaxRate { get; set; } = null!;

    public string TaxRate2 { get; set; } = null!;

    public string CSku { get; set; } = null!;

    public string? CBarcode { get; set; }

    public string CUseStock { get; set; } = null!;

    public string? CIsQuantityDivisible { get; set; }

    public decimal? FQuantity { get; set; }

    public string? CUnit { get; set; }

    public string? CAnnotation { get; set; }

    public string? Tags { get; set; }

    public byte NIsParent { get; set; }

    public int KParentId { get; set; }

    public string Variants { get; set; } = null!;

    public DateTime? DUpdatedAt { get; set; }

    public DateTime? DCreatedAt { get; set; }

    public int KSteuerklasse { get; set; }

    public int? KCompany { get; set; }

    public int NStatus { get; set; }

    public bool? NIsCompositeProduct { get; set; }

    public byte NHasBestBeforeDate { get; set; }

    public byte NHasLotNumber { get; set; }

    public string? CHasSerialNumber { get; set; }

    public string? CUpc { get; set; }

    public byte[] BLastChanged { get; set; } = null!;

    public int KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }

    public decimal? FReservedQuantity { get; set; }

    public string? CManufacturerName { get; set; }

    public string? CHan { get; set; }

    public string? CIsbn { get; set; }

    public byte NProductType { get; set; }

    public string? CVoucherCampaign { get; set; }

    public decimal? NVoucherAmount { get; set; }

    public string? CVoucherCurrency { get; set; }

    public int? NVoucherType { get; set; }

    public byte? NPurposeType { get; set; }

    public bool? NFixedAmount { get; set; }
}
