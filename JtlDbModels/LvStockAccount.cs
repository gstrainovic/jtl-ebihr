using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvStockAccount
{
    public int? KId { get; set; }

    public int? KArtikel { get; set; }

    public string? CBinName { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int? KBinType { get; set; }

    public int NStatus { get; set; }

    public decimal FStockQuantity { get; set; }

    public decimal? FReservedQuantity { get; set; }

    public int KReference { get; set; }

    public int? NSort { get; set; }

    public decimal FMaxWeight { get; set; }

    public decimal FUsedCapacityVolume { get; set; }

    public decimal FUsedCapacityWeight { get; set; }

    public decimal FSumWeight { get; set; }

    public decimal FSumVolume { get; set; }

    public decimal FMaxVolume { get; set; }

    public bool? NCapacityVolumeValid { get; set; }

    public bool? NCapacityWeightValid { get; set; }

    public bool? NGesperrt { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FHoehe { get; set; }

    public decimal FBreite { get; set; }

    public string? CBatchNumber { get; set; }

    public DateTime? DShelfLifeEndDate { get; set; }
}
