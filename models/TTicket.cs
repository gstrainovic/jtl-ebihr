using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTicket
{
    public int KTicket { get; set; }

    public string CEindeutigeId { get; set; } = null!;

    public int KStatus { get; set; }

    public byte NPrioritaet { get; set; }

    public DateTime? DLoesung { get; set; }

    public DateTime? DAenderung { get; set; }

    public DateTime? DWiedervorlage { get; set; }

    public DateTime? DFaelligAm { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KBenutzerErsteller { get; set; }

    public int? KBenutzerBearbeiter { get; set; }

    public int? KKunde { get; set; }

    public bool NIstInPapierkorb { get; set; }

    public int? KLieferant { get; set; }

    public bool NBenutzererstellt { get; set; }

    public bool NVollstaendigAngelegt { get; set; }

    public virtual Tkunde? KKundeNavigation { get; set; }

    public virtual Tlieferant? KLieferantNavigation { get; set; }

    public virtual TStatus KStatusNavigation { get; set; } = null!;

    public virtual ICollection<TAgentAngeseheneTicket> TAgentAngeseheneTickets { get; set; } = new List<TAgentAngeseheneTicket>();

    public virtual ICollection<TAgentLiestTicket> TAgentLiestTickets { get; set; } = new List<TAgentLiestTicket>();

    public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurves { get; set; } = new List<TNachrichtEntwurf>();

    public virtual ICollection<TNachricht> TNachrichts { get; set; } = new List<TNachricht>();

    public virtual ICollection<TNotiz1> TNotiz1s { get; set; } = new List<TNotiz1>();

    public virtual ICollection<TNotizEntwurf> TNotizEntwurves { get; set; } = new List<TNotizEntwurf>();

    public virtual ICollection<TTelefonatEntwurf> TTelefonatEntwurves { get; set; } = new List<TTelefonatEntwurf>();

    public virtual ICollection<TTelefonat> TTelefonats { get; set; } = new List<TTelefonat>();

    public virtual ICollection<TTicketBeobachter> TTicketBeobachters { get; set; } = new List<TTicketBeobachter>();

    public virtual TTicketEckdaten? TTicketEckdaten { get; set; }

    public virtual ICollection<TTicketLabel> TTicketLabels { get; set; } = new List<TTicketLabel>();

    public virtual ICollection<TTicketRelation> TTicketRelationKBasisticketNavigations { get; set; } = new List<TTicketRelation>();

    public virtual ICollection<TTicketRelation> TTicketRelationKVerknuepftesTicketNavigations { get; set; } = new List<TTicketRelation>();
}
