using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKonfigItem
{
    public int KKonfigitem { get; set; }

    public int? KKonfiggruppe { get; set; }

    public int? KArtikel { get; set; }

    public int? NPosTyp { get; set; }

    public byte? BSelektiert { get; set; }

    public byte? BEmpfohlen { get; set; }

    public byte? BName { get; set; }

    public byte? BPreis { get; set; }

    public int? NSort { get; set; }

    public byte? BRabatt { get; set; }

    public byte? BZuschlag { get; set; }

    public decimal FMin { get; set; }

    public decimal FMax { get; set; }

    public decimal FInitial { get; set; }

    public decimal FStandardpreis { get; set; }

    public byte BIgnoreMultiplier { get; set; }
}
