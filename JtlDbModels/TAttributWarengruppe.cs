using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAttributWarengruppe
{
    public int KAttributWarengruppe { get; set; }

    public int KWarengruppe { get; set; }

    public int KAttribut { get; set; }

    public virtual TAttribut KAttributNavigation { get; set; } = null!;

    public virtual TWarengruppe KWarengruppeNavigation { get; set; } = null!;
}
