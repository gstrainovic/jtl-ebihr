﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class DeliveryNotePositionConfiguration
{
    public int InternalId { get; set; }

    public int ConfigurationValueInternalId { get; set; }

    public int DeliveryNotePositionInternalId { get; set; }

    public int? ProductInternalId { get; set; }

    public decimal AdditionalNetPrice { get; set; }

    public string ValueText { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int ConfigurationInternalId { get; set; }
}
