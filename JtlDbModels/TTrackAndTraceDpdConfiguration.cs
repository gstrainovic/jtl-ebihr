using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTrackAndTraceDpdConfiguration
{
    public int KVersandart { get; set; }

    public string CDelisId { get; set; } = null!;

    public virtual Tversandart KVersandartNavigation { get; set; } = null!;
}
