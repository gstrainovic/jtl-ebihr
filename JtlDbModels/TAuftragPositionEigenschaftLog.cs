﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragPositionEigenschaftLog
{
    public int KAuftragPositionEigenschaftLog { get; set; }

    public int? KBenutzerLog { get; set; }

    public DateTime DLog { get; set; }

    public int NActionLog { get; set; }

    public int KAuftragPositionEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public int KAuftragPosition { get; set; }

    public int? KEigenschaft { get; set; }

    public decimal FAufpreisNetto { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public string CWert { get; set; } = null!;

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
