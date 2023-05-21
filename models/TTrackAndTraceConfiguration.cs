using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTrackAndTraceConfiguration
{
    public int KVersandart { get; set; }

    public int NTrackAndTraceProviderType { get; set; }

    public byte NIsEnabled { get; set; }

    public virtual Tversandart KVersandartNavigation { get; set; } = null!;
}
