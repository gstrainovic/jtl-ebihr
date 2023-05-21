using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayUser
{
    public int KEbayuser { get; set; }

    public string Login { get; set; } = null!;

    public string? Passwort { get; set; }

    public int SiteId { get; set; }

    public string Name { get; set; } = null!;

    public string? Umgebung { get; set; }

    public int? KFirma { get; set; }

    public byte? NSonderRegel { get; set; }

    public byte? NEbayPayment { get; set; }

    public byte NOutOfStockControl { get; set; }

    public DateTime? DLetzterBestellabgleich { get; set; }

    public string? CEbayUsername { get; set; }

    public DateTime? DLetzerEbayAbgleich { get; set; }

    public byte NLagerbestaendeAendern { get; set; }

    public virtual ICollection<EbayDataMembermessageIn> EbayDataMembermessageIns { get; set; } = new List<EbayDataMembermessageIn>();

    public virtual ICollection<EbayDataMembermessageOut> EbayDataMembermessageOuts { get; set; } = new List<EbayDataMembermessageOut>();

    public virtual ICollection<TNegotiationGlobaleEinstellungen> TNegotiationGlobaleEinstellungens { get; set; } = new List<TNegotiationGlobaleEinstellungen>();

    public virtual ICollection<TNegotiationItem> TNegotiationItems { get; set; } = new List<TNegotiationItem>();

    public virtual ICollection<TNegotiationVerlauf> TNegotiationVerlaufs { get; set; } = new List<TNegotiationVerlauf>();
}
