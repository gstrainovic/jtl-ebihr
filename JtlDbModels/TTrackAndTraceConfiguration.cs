using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTrackAndTraceConfiguration
{
    public int KVersandart { get; set; }

    public int NTrackAndTraceProviderType { get; set; }

    public byte NIsEnabled { get; set; }

    public virtual Tversandart KVersandartNavigation { get; set; } = null!;
}
