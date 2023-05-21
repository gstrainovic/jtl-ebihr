using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVerfuegbarkeitsAnfrage
{
    public int KVerfuegbarkeitsanfrage { get; set; }

    public int? KArtikel { get; set; }

    public int? KShop { get; set; }

    public string? CEmail { get; set; }

    public DateTime? DDatum { get; set; }

    public string? CName { get; set; }

    public string? CVorname { get; set; }

    public string? CAnrede { get; set; }

    public int? KInetVerfuegbarkeit { get; set; }

    public short? NStatus { get; set; }

    public DateTime? DBenachrichtigtAm { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
