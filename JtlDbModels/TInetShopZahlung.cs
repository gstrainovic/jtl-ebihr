using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TInetShopZahlung
{
    public int KZahlungseingang { get; set; }

    public int? KInetBestellung { get; set; }

    public int KShop { get; set; }

    public int? KZahlung { get; set; }

    public string? CZahlungsanbieter { get; set; }

    public decimal FBetrag { get; set; }

    public decimal FZahlungsgebuehr { get; set; }

    public string? CIso { get; set; }

    public string? CEmpfaenger { get; set; }

    public string? CZahler { get; set; }

    public string? DZeit { get; set; }

    public string? CHinweis { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
