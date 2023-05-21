using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelbildPlattform
{
    public int KArtikelbildPlattform { get; set; }

    public int KBild { get; set; }

    public int KArtikel { get; set; }

    public int KPlattform { get; set; }

    public int KShop { get; set; }

    public int NNr { get; set; }

    public byte NInet { get; set; }

    public int KEbayUser { get; set; }

    public string? CBildname { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TProductPictureRef> TProductPictureRefs { get; set; } = new List<TProductPictureRef>();
}
