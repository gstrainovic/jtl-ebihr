using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VProduct1
{
    public int Pk { get; set; }

    public string? Jfsku { get; set; }

    public string? Name { get; set; }

    public string? MerchantSku { get; set; }

    public string WawiProductNumber { get; set; } = null!;

    public string? ProductGroup { get; set; }

    public string? OriginCountry { get; set; }

    public decimal Weight { get; set; }

    public decimal NetWeight { get; set; }

    public string? Note { get; set; }

    public string? Manufacturer { get; set; }

    public string? IdentifierEan { get; set; }

    public string? IdentifierIsbn { get; set; }

    public string? IdentifierUpc { get; set; }

    public string? IdentifierAsin { get; set; }

    public bool? IsWarehouseActive { get; set; }

    public bool? SpecificationsIsBatch { get; set; }

    public bool? SpecificationsIsDivisible { get; set; }

    public bool? SpecificationsIsBestBefore { get; set; }

    public bool? SpecificationsIsSerialNumber { get; set; }

    public string? SpecificationsHazardIdentifier { get; set; }

    public string? SpecificationsUnNumber { get; set; }

    public string? SpecificationsTaric { get; set; }

    public string? SpecificationsFnsku { get; set; }

    public bool? SpecificationsIsBillOfMaterials { get; set; }

    public byte SpecificationsIsVariationCombination { get; set; }

    public bool? SpecificationsIsConfiguration { get; set; }

    public string? IdentifierMpnManufacturer { get; set; }

    public string? IdentifierMpnPartNumber { get; set; }

    public decimal DimensionsWidth { get; set; }

    public decimal DimensionsLength { get; set; }

    public decimal DimensionsHeight { get; set; }

    public decimal NetRetailPriceAmount { get; set; }

    public string NetRetailPriceCurrency { get; set; } = null!;

    public int? FfnCondition { get; set; }

    public int? ZustandKey { get; set; }
}
