using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicVersand
{
    public int? KArtikelBild { get; set; }

    public int? KKategoriePict { get; set; }

    public int? KEigenschaftWertPict { get; set; }

    public int? KEa { get; set; }

    public int? KShop { get; set; }

    public string? DMod { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
