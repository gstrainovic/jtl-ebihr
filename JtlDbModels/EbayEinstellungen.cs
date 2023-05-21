using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayEinstellungen
{
    public int KEbayEinstellungen { get; set; }

    public byte? NCheckout { get; set; }

    public byte? NVean { get; set; }

    public byte? NVisbn { get; set; }

    public byte? NVupc { get; set; }

    public byte? NVepid { get; set; }

    public byte? NVhan { get; set; }

    public byte? NArtnamenutzen { get; set; }

    public byte? NUsePremium { get; set; }

    public byte? NUseGalleryPlus { get; set; }

    public byte? NVersandartPraefixVerwenden { get; set; }

    public byte? NNichtLaufendeLoeschen { get; set; }

    public string CAuftraegeAusgabeweg { get; set; } = null!;
}
