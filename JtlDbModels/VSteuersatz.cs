using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VSteuersatz
{
    public int KSteuersatz { get; set; }

    public int? KSteuerzone { get; set; }

    public int? KSteuerklasse { get; set; }

    public decimal FSteuersatz { get; set; }

    public byte? NPrio { get; set; }

    public int? KFirma { get; set; }
}
