using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFirmaAufbewahrungsfrist
{
    public int KAufbewahrungsfrist { get; set; }

    public int KFirma { get; set; }

    public int? KBenutzer { get; set; }

    public int? NYears { get; set; }

    public int? NMonths { get; set; }

    public int? NDays { get; set; }

    public bool NObfuskieren { get; set; }

    public string CVorgangsId { get; set; } = null!;

    public DateTime? DFestgeschrieben { get; set; }
}
