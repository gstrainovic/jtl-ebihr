using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VKundenGruppeShopVerfuegbar
{
    public int KKundenGruppe { get; set; }

    public string? CName { get; set; }

    public byte? NStandard { get; set; }

    public byte? NShopLogin { get; set; }

    public byte? NNettoPreise { get; set; }

    public decimal FRabatt { get; set; }

    public int? KKundenDrucktext { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NRabattVeraendert { get; set; }

    public int KWebShop { get; set; }

    public string? CWebShop { get; set; }
}
