﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VExportDocumentsShippingPosition
{
    public string? Beschreibung { get; set; }

    public string? StandardBeschreibung { get; set; }

    public decimal? Wert { get; set; }

    public byte Typ { get; set; }

    public int KAuftrag { get; set; }
}
