using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAmazonCompetitorAsinStrategy
{
    public int KAmazonCompetitorAsinStrategy { get; set; }

    public decimal FMinPreis { get; set; }

    public decimal FMaxPreis { get; set; }

    public decimal FPreisabstand { get; set; }

    public byte NAufschlagProzentNutzen { get; set; }

    public decimal FMinPreisAufschlagProzent { get; set; }

    public decimal FMaxPreisAufschlagProzent { get; set; }

    public byte? NFulfillment { get; set; }

    public byte? NRatingCount { get; set; }

    public byte? NRating { get; set; }

    public int NDeliveryTimeMin { get; set; }

    public int NDeliveryTimeMax { get; set; }

    public byte NAufschlagKalkulation { get; set; }

    public string CMinPreisFormel { get; set; } = null!;

    public string CMaxPreisFormel { get; set; } = null!;

    public virtual ICollection<TAmazonCompetitor> TAmazonCompetitors { get; set; } = new List<TAmazonCompetitor>();

    public virtual ICollection<TAmazonStrategieAuswahl> TAmazonStrategieAuswahls { get; set; } = new List<TAmazonStrategieAuswahl>();
}
