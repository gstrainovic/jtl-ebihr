using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZavorlage
{
    public int KZavorlage { get; set; }

    public string? CName { get; set; }

    public int? NZeilen { get; set; }

    public byte? NTrenner { get; set; }

    public byte? NPosDatum { get; set; }

    public byte? NPosVorgang { get; set; }

    public byte? NPosVerwendung { get; set; }

    public byte? NPosVorname { get; set; }

    public byte? NPosName { get; set; }

    public byte? NPosUmsatz { get; set; }

    public int? NSpalten { get; set; }

    public string? CZahlungsArt { get; set; }

    public byte? NPosVerwendung2 { get; set; }

    public byte? NPosVerwendung3 { get; set; }

    public byte? NPosVerwendung4 { get; set; }

    public byte? NPosVerwendung5 { get; set; }

    public byte? NPosVerwendung6 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
