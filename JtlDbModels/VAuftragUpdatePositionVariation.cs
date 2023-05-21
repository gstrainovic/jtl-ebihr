using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragUpdatePositionVariation
{
    public int KAuftragPosition { get; set; }

    public int? KEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public string CEigenschaftName { get; set; } = null!;

    public string CEigenschaftWertName { get; set; } = null!;

    public string CFreifeldWert { get; set; } = null!;

    public decimal FAufpreis { get; set; }
}
