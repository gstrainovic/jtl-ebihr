using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAmazonBuyBoxStrategy
{
    public int KAmazonBuyBoxStrategy { get; set; }

    public decimal FMinPreis { get; set; }

    public decimal FMaxPreis { get; set; }

    public decimal? FPreisabstand { get; set; }

    public byte NPreisabstandNutzen { get; set; }

    public byte NAufschlagProzentNutzen { get; set; }

    public decimal FMinPreisAufschlagProzent { get; set; }

    public decimal FMaxPreisAufschlagProzent { get; set; }

    public byte NAufschlagKalkulation { get; set; }

    public string CMinPreisFormel { get; set; } = null!;

    public string CMaxPreisFormel { get; set; } = null!;

    public virtual ICollection<TAmazonStrategieAuswahl> TAmazonStrategieAuswahls { get; set; } = new List<TAmazonStrategieAuswahl>();
}
