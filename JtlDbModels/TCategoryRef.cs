using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCategoryRef
{
    public int KCategoryRef { get; set; }

    public int KKategorie { get; set; }

    public string? CMerchantId { get; set; }

    public string? CProductGroup { get; set; }

    public virtual Tkategorie KKategorieNavigation { get; set; } = null!;
}
