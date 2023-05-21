using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VVcsBestelldatumLand
{
    public int KBestelldatumLand { get; set; }

    public int KUser { get; set; }

    public DateTime? DBestellDatum { get; set; }

    public DateTime? DVcsDatum { get; set; }

    public string CShipFromCountry { get; set; } = null!;
}
