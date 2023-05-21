using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonUmlagerungVersendet
{
    public int KAmazonUmlagerungVersendet { get; set; }

    public int KAuftrag { get; set; }

    public DateTime? DBearbeitet { get; set; }

    public string? CShipmentId { get; set; }

    public byte NIsPartnered { get; set; }

    public string? CCarrier { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;

    public virtual ICollection<PfAmazonUmlagerungVersendetPo> PfAmazonUmlagerungVersendetPos { get; set; } = new List<PfAmazonUmlagerungVersendetPo>();
}
