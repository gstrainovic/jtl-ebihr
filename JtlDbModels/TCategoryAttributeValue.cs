using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCategoryAttributeValue
{
    public int KCategoryAttributeValue { get; set; }

    public int KCategoryAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public string CDisplayName { get; set; } = null!;

    public int NSort { get; set; }

    public virtual TCategoryAttribute KCategoryAttributeNavigation { get; set; } = null!;
}
