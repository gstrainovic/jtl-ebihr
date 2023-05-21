using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSteuersatz
{
    public int KSteuersatz { get; set; }

    public int? KSteuerzone { get; set; }

    public int? KSteuerklasse { get; set; }

    public decimal FSteuersatz { get; set; }

    public byte? NPrio { get; set; }

    public int? KStSchl { get; set; }

    public int? KStSchlIgl { get; set; }

    public int? KStSchlUstIgl { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KStSchlReverse { get; set; }
}
