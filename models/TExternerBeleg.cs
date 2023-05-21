using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TExternerBeleg
{
    public int KExternerBeleg { get; set; }

    public string CBelegnr { get; set; } = null!;

    public DateTime DBelegdatumUtc { get; set; }

    public byte NBelegtyp { get; set; }

    public int KFirmaHistory { get; set; }

    public string? CFirmaUstid { get; set; }

    public int KPlattform { get; set; }

    public int? KPlattformKey { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public string? CKaeuferUstId { get; set; }

    public string CRaname { get; set; } = null!;

    public string CRaadresse1 { get; set; } = null!;

    public string CRaadresse2 { get; set; } = null!;

    public string CRaadresse3 { get; set; } = null!;

    public string CRaort { get; set; } = null!;

    public string CRastaat { get; set; } = null!;

    public string CRapostcode { get; set; } = null!;

    public string CRalandIso { get; set; } = null!;

    public string CRatelefon { get; set; } = null!;

    public string? CBezugsbelegnr { get; set; }

    public string? CHinweis { get; set; }

    public virtual TFirmaHistory KFirmaHistoryNavigation { get; set; } = null!;

    public virtual TPlattform KPlattformNavigation { get; set; } = null!;

    public virtual TExternerBelegEckdaten? TExternerBelegEckdaten { get; set; }

    public virtual ICollection<TExternerBelegTransaktion> TExternerBelegTransaktions { get; set; } = new List<TExternerBelegTransaktion>();
}
