using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAbverkauf
{
    public int KAbverkauf { get; set; }

    public byte NAktiv { get; set; }

    public int NBestandBis { get; set; }

    public decimal FAenderungMinPreis { get; set; }

    public decimal FAenderungMaxPreis { get; set; }

    public byte NAenderungMinPreisTyp { get; set; }

    public byte NAenderungMaxPreisTyp { get; set; }

    public virtual ICollection<TAmazonStrategieAuswahl> TAmazonStrategieAuswahls { get; set; } = new List<TAmazonStrategieAuswahl>();
}
