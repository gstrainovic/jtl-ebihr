using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tansprechpartner
{
    public int KAnsprechpartner { get; set; }

    public int? KLieferant { get; set; }

    public int? KKunde { get; set; }

    public string? CName { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CMail { get; set; }

    public string? CAbteilung { get; set; }

    public string? CVorName { get; set; }

    public string? CAnrede { get; set; }

    public string? CMobil { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
