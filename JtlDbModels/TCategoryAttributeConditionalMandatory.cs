﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCategoryAttributeConditionalMandatory
{
    public int KCategoryAttributeConditionalMandatory { get; set; }

    public int KCategoryAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public virtual TCategoryAttribute KCategoryAttributeNavigation { get; set; } = null!;
}
