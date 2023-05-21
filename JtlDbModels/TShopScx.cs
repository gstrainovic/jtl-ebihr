using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopScx
{
    public int KShopScx { get; set; }

    public int KShop { get; set; }

    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public DateTime DCreated { get; set; }

    public DateTime? DUpdated { get; set; }

    public string? CReason { get; set; }

    public int? KVersandart { get; set; }

    public int NLoeschintervallSchwebendAngebot { get; set; }

    public int NLoeschintervallBeendetAngebot { get; set; }

    public DateTime? DSellerAttributeAktualisierungUtc { get; set; }

    public virtual TChannel KChannelNavigation { get; set; } = null!;

    public virtual ICollection<TArtikelVerkaufskanalFeldWert> TArtikelVerkaufskanalFeldWerts { get; set; } = new List<TArtikelVerkaufskanalFeldWert>();

    public virtual ICollection<TVerkaufskanalArtikelDatum> TVerkaufskanalArtikelData { get; set; } = new List<TVerkaufskanalArtikelDatum>();

    public virtual ICollection<TVerkaufskanalCategoryFeldWert> TVerkaufskanalCategoryFeldWerts { get; set; } = new List<TVerkaufskanalCategoryFeldWert>();

    public virtual ICollection<TVerkaufskanalChannelFeldWert> TVerkaufskanalChannelFeldWerts { get; set; } = new List<TVerkaufskanalChannelFeldWert>();

    public virtual ICollection<TVerkaufskanalKategoriemapping> TVerkaufskanalKategoriemappings { get; set; } = new List<TVerkaufskanalKategoriemapping>();
}
