﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TConnectorLogeintrag
{
    public int KConnectorLogeintrag { get; set; }

    public int KSyncLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public int? KShop { get; set; }

    public string? CMeldung { get; set; }

    public byte NCallType { get; set; }

    public string? CExtendedMessage { get; set; }

    public virtual TSyncLogsitzung KSyncLogsitzungNavigation { get; set; } = null!;
}
