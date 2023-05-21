using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TNachricht
{
    public int KNachricht { get; set; }

    public string? CInhalt { get; set; }

    public DateTime DErstellung { get; set; }

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KTicket { get; set; }

    public int? KBenutzerErsteller { get; set; }

    public byte NRichtung { get; set; }

    public DateTime DEmpfangen { get; set; }

    public DateTime? DGesendet { get; set; }

    public bool NVorgangserkennungGelaufen { get; set; }

    public int KFileHtmlInhalt { get; set; }

    public bool NVollstaendigAngelegt { get; set; }

    public virtual TFile KFileHtmlInhaltNavigation { get; set; } = null!;

    public virtual TTicket KTicketNavigation { get; set; } = null!;

    public virtual TAbgerufeneEmailsImap? TAbgerufeneEmailsImap { get; set; }

    public virtual TAbgerufeneEmailsPop3? TAbgerufeneEmailsPop3 { get; set; }

    public virtual ICollection<TAgentAngeseheneTicket> TAgentAngeseheneTickets { get; set; } = new List<TAgentAngeseheneTicket>();

    public virtual ICollection<TNachrichtAngebot> TNachrichtAngebots { get; set; } = new List<TNachrichtAngebot>();

    public virtual ICollection<TNachrichtArtikel> TNachrichtArtikels { get; set; } = new List<TNachrichtArtikel>();

    public virtual ICollection<TNachrichtAuftrag> TNachrichtAuftrags { get; set; } = new List<TNachrichtAuftrag>();

    public virtual ICollection<TNachrichtBenutzerOptionen> TNachrichtBenutzerOptionens { get; set; } = new List<TNachrichtBenutzerOptionen>();

    public virtual ICollection<TNachrichtEingangsrechnung> TNachrichtEingangsrechnungs { get; set; } = new List<TNachrichtEingangsrechnung>();

    public virtual ICollection<TNachrichtLieferantenbestellung> TNachrichtLieferantenbestellungs { get; set; } = new List<TNachrichtLieferantenbestellung>();

    public virtual ICollection<TNachrichtPreisanfrage> TNachrichtPreisanfrages { get; set; } = new List<TNachrichtPreisanfrage>();

    public virtual ICollection<TNachrichtRechnung> TNachrichtRechnungs { get; set; } = new List<TNachrichtRechnung>();

    public virtual ICollection<TNachrichtRechnungskorrektur> TNachrichtRechnungskorrekturs { get; set; } = new List<TNachrichtRechnungskorrektur>();

    public virtual ICollection<TNachrichtRetoure> TNachrichtRetoures { get; set; } = new List<TNachrichtRetoure>();

    public virtual ICollection<TNachrichtTyp> TNachrichtTyps { get; set; } = new List<TNachrichtTyp>();

    public virtual ICollection<TNachrichtenanhang> TNachrichtenanhangs { get; set; } = new List<TNachrichtenanhang>();
}
