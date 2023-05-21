using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersand
{
    public int KVersand { get; set; }

    public int KLieferschein { get; set; }

    public int KBenutzer { get; set; }

    public int? KLogistik { get; set; }

    public string? CIdentCode { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CHinweis { get; set; }

    public decimal FGewicht { get; set; }

    public int? KVersandArt { get; set; }

    public string? CLogistiker { get; set; }

    public string? CFulfillmentCenter { get; set; }

    public DateTime? DAnkunftszeit { get; set; }

    public int? NVerpackZeitSek { get; set; }

    public DateTime? DVersendet { get; set; }

    public byte NStatus { get; set; }

    public string? CShipmentId { get; set; }

    public string? CReference { get; set; }

    public string? CShipmentOrderId { get; set; }

    public int? KKartonAuftragPos { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CEnclosedReturnIdentCode { get; set; }

    public int NViaAmazonMws { get; set; }

    public int? KReturnVersandart { get; set; }

    public virtual ICollection<TMerchantVersandRef> TMerchantVersandRefs { get; set; } = new List<TMerchantVersandRef>();

    public virtual ICollection<TPackage> TPackages { get; set; } = new List<TPackage>();
}
