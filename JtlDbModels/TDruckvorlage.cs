using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDruckvorlage
{
    public int KDruckvorlage { get; set; }

    public int? KFirma { get; set; }

    public int? KSprache { get; set; }

    public int? KKundenGruppe { get; set; }

    public int? KLlvorlage { get; set; }

    public string? CName { get; set; }

    public byte? NStandard { get; set; }

    public int? KFormType { get; set; }

    public byte? NAusgabe { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
