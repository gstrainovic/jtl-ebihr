using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class THintergrundDienst
{
    public int? NSek { get; set; }

    public byte? NKeinShop { get; set; }

    public byte? NKundenupdate { get; set; }

    public byte? NAktiv { get; set; }

    public byte? NReDrucken { get; set; }

    public byte? NWebshopAuftrag { get; set; }

    public byte? NKeinEbay { get; set; }

    public byte? NEbaySmall { get; set; }

    public byte? NEbayAuftrag { get; set; }

    public byte? NKeinAmazon { get; set; }

    public byte? NAmazonAuftrag { get; set; }

    public byte? NEbayBestand { get; set; }

    public byte? NWaehrung { get; set; }

    public byte? NRepricer { get; set; }

    public byte? NRetourenErstellen { get; set; }

    public byte? NUpdateBilderBeschreibung { get; set; }

    public byte? NKeinFulfillment { get; set; }

    public byte NKeinZahlungsabgleich { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
