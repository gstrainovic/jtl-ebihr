using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMargensteigerung
{
    public int KMargensteigerung { get; set; }

    public byte NAktiv { get; set; }

    public int NBestandAb { get; set; }

    public decimal FAenderungMinPreis { get; set; }

    public decimal FAenderungMaxPreis { get; set; }

    public byte NAenderungMinPreisTyp { get; set; }

    public byte NAenderungMaxPreisTyp { get; set; }

    public virtual ICollection<TAmazonStrategieAuswahl> TAmazonStrategieAuswahls { get; set; } = new List<TAmazonStrategieAuswahl>();
}
