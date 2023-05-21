using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNegotiationGlobaleEinstellungen
{
    public int KNegotiationGlobaleEinstellungen { get; set; }

    public int KEbayuser { get; set; }

    public byte NAutomatischVersenden { get; set; }

    public byte NIstProzentual { get; set; }

    public string CNachricht { get; set; } = null!;

    public decimal FRabattProzentual { get; set; }

    public decimal FRabattAbsolut { get; set; }

    public int NRabattMenge { get; set; }

    public virtual EbayUser KEbayuserNavigation { get; set; } = null!;
}
