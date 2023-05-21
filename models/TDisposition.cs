using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TDisposition
{
    public int KDisposition { get; set; }

    public int KArtikel { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public decimal FQuantity { get; set; }

    public byte NStatus { get; set; }

    public int? KBenutzer { get; set; }

    public string? CComment { get; set; }

    public DateTimeOffset? DIntendedCompletionDate { get; set; }

    public byte NReferenceType { get; set; }

    public int? KReference { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal FActualQuantity { get; set; }

    public decimal FPlannedQuantity { get; set; }

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;

    public virtual ICollection<TProductionOrderProducible> TProductionOrderProducibles { get; set; } = new List<TProductionOrderProducible>();

    public virtual ICollection<TWorkJob> KWorkJobs { get; set; } = new List<TWorkJob>();
}
