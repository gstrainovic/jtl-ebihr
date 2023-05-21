using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayXxSite
{
    public int SiteId { get; set; }

    public string CAbbreviation { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string CSiteCodeType { get; set; } = null!;

    public string CSprachIso { get; set; } = null!;

    public string CLandIso { get; set; } = null!;

    public DateTime? DLastUpdate { get; set; }

    public int NVersion { get; set; }

    public string Www { get; set; } = null!;

    public int KPlattform { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public virtual ICollection<TArtikelEpid> TArtikelEpids { get; set; } = new List<TArtikelEpid>();

    public virtual ICollection<TNegotiationItem> TNegotiationItems { get; set; } = new List<TNegotiationItem>();

    public virtual ICollection<TNegotiationVerlauf> TNegotiationVerlaufs { get; set; } = new List<TNegotiationVerlauf>();
}
