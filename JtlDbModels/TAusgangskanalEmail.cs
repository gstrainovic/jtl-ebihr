using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAusgangskanalEmail
{
    public int KAusgangskanalEmail { get; set; }

    public byte NProtokoll { get; set; }

    public string? CServeradresse { get; set; }

    public string? CServerport { get; set; }

    public byte CVerschluesselung { get; set; }

    public string? CBenutzername { get; set; }

    public string? CName { get; set; }

    public bool NStandard { get; set; }

    public string? CEmailAdresse { get; set; }

    public string? CPasswort { get; set; }

    public int? KStatusAntwortGeschrieben { get; set; }

    public virtual TStatus? KStatusAntwortGeschriebenNavigation { get; set; }

    public virtual ICollection<TAusgangskanalEmailBenutzerSignatur> TAusgangskanalEmailBenutzerSignaturs { get; set; } = new List<TAusgangskanalEmailBenutzerSignatur>();

    public virtual ICollection<TEingangskanalEmail> TEingangskanalEmails { get; set; } = new List<TEingangskanalEmail>();

    public virtual ICollection<TNachrichtEntwurf> TNachrichtEntwurves { get; set; } = new List<TNachrichtEntwurf>();
}
