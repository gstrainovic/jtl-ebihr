using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvBinOverview
{
    public int KId { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public string? CBinName { get; set; }

    public int? KBinType { get; set; }

    public int NStatus { get; set; }

    public int? NAnzahlArtikel { get; set; }

    public string? CArtikelNr { get; set; }

    public decimal FAnzahlAktuell { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public decimal FMaxWeight { get; set; }

    public int? NSort { get; set; }

    public bool? NGesperrt { get; set; }

    public decimal FUsedCapacityVolume { get; set; }

    public decimal FUsedCapacityWeight { get; set; }

    public decimal FSumWeight { get; set; }

    public decimal FSumVolume { get; set; }

    public decimal FMaxVolume { get; set; }

    public bool? NCapacityVolumeValid { get; set; }

    public bool? NCapacityWeightValid { get; set; }

    public int KWarenlager { get; set; }

    public int? KWorkbenchResource { get; set; }
}
