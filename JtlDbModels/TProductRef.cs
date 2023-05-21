using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductRef
{
    public int KProductRef { get; set; }

    public int KArtikel { get; set; }

    public byte NType { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public string? COwnerId { get; set; }

    public string? CJfsku { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte? NCondition { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual ICollection<TFulfillerProductAttributeAtFfn> TFulfillerProductAttributeAtFfns { get; set; } = new List<TFulfillerProductAttributeAtFfn>();
}
