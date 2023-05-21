using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TNegotiationAutomatisierung
{
    public int KNegotiationAutomatisierung { get; set; }

    public int? KEbayItem { get; set; }

    public byte NIstAngebotsIndividuell { get; set; }

    public byte NIstAutomatisiert { get; set; }

    public byte NIstProzentual { get; set; }

    public decimal FRabattProzentual { get; set; }

    public decimal FRabattAbsolut { get; set; }

    public string CNachricht { get; set; } = null!;

    public int NRabattmenge { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KAlienItem { get; set; }

    public virtual EbayAlienitem? KAlienItemNavigation { get; set; }

    public virtual EbayItem? KEbayItemNavigation { get; set; }
}
