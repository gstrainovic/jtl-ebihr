using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelEpid
{
    public long KArtikelEpid { get; set; }

    public int KArtikel { get; set; }

    public int KSiteId { get; set; }

    public string CEpid { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual EbayXxSite KSite { get; set; } = null!;
}
