using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAmazonStrategieAuswahl
{
    public int KAmazonStrategieAuswahl { get; set; }

    public int? KAmazonBuyBoxStrategy { get; set; }

    public int? KAmazonCompetitorAsinStrategy { get; set; }

    public int? KMargensteigerung { get; set; }

    public int? KAbverkauf { get; set; }

    public byte NAktiveStrategie { get; set; }

    public virtual TAbverkauf? KAbverkaufNavigation { get; set; }

    public virtual TAmazonBuyBoxStrategy? KAmazonBuyBoxStrategyNavigation { get; set; }

    public virtual TAmazonCompetitorAsinStrategy? KAmazonCompetitorAsinStrategyNavigation { get; set; }

    public virtual TMargensteigerung? KMargensteigerungNavigation { get; set; }

    public virtual ICollection<TAmazonTask> TAmazonTasks { get; set; } = new List<TAmazonTask>();

    public virtual TVorlage1? TVorlage1 { get; set; }
}
