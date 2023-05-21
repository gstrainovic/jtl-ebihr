using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TInventurArtikel
{
    public int KArtikel { get; set; }

    public int KWmsInventur { get; set; }

    public byte NBearbeitet { get; set; }

    public DateTime? DInventurDatum { get; set; }

    public virtual TWmsInventur KWmsInventurNavigation { get; set; } = null!;
}
