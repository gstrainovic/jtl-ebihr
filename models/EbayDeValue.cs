﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayDeValue
{
    public int? ValueId { get; set; }

    public int? AttributeId { get; set; }

    public int? AttributeSetId { get; set; }

    public int ParentValueId { get; set; }

    public string? Name { get; set; }
}
