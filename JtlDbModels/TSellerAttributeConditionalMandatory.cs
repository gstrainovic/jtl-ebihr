﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSellerAttributeConditionalMandatory
{
    public int KSellerAttributeConditionalMandatory { get; set; }

    public int KSellerAttribute { get; set; }

    public string CValue { get; set; } = null!;

    public virtual TSellerAttribute KSellerAttributeNavigation { get; set; } = null!;
}
