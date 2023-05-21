using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWmsInventur
{
    public int KWmsInventur { get; set; }

    public string? CKommentar { get; set; }

    public DateTime? DAngelegt { get; set; }

    public int? KBenutzer { get; set; }

    public int? NStatus { get; set; }

    public int? KWarenlager { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NCreatedMobile { get; set; }

    public virtual ICollection<TInventurArtikel> TInventurArtikels { get; set; } = new List<TInventurArtikel>();
}
