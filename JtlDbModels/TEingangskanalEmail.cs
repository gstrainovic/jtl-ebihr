using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEingangskanalEmail
{
    public int KEingangskanalEmail { get; set; }

    public byte NProtokoll { get; set; }

    public string CServeradresse { get; set; } = null!;

    public string CServerport { get; set; } = null!;

    public byte CVerschluesselung { get; set; }

    public string CBenutzername { get; set; } = null!;

    public int? NMaximalesEmailAlter { get; set; }

    public int? NIntervall { get; set; }

    public int? KAusgangskanalEmail { get; set; }

    public string? CName { get; set; }

    public string? CEmailAdresse { get; set; }

    public string? CPasswort { get; set; }

    public int KStatusNeuesTicket { get; set; }

    public int? KStatusNeueAntwort { get; set; }

    public bool NGeleseneNachrichtenAbholen { get; set; }

    public byte NMailNachDemAbrufenLoeschen { get; set; }

    public long? NNeuesteUniqueIdImap { get; set; }

    public virtual TAusgangskanalEmail? KAusgangskanalEmailNavigation { get; set; }

    public virtual TStatus? KStatusNeueAntwortNavigation { get; set; }

    public virtual TStatus KStatusNeuesTicketNavigation { get; set; } = null!;

    public virtual ICollection<TAbgerufeneEmailsImap> TAbgerufeneEmailsImaps { get; set; } = new List<TAbgerufeneEmailsImap>();

    public virtual ICollection<TAbgerufeneEmailsPop3> TAbgerufeneEmailsPop3s { get; set; } = new List<TAbgerufeneEmailsPop3>();

    public virtual ICollection<TEingangskanalEmailLabel> TEingangskanalEmailLabels { get; set; } = new List<TEingangskanalEmailLabel>();
}
