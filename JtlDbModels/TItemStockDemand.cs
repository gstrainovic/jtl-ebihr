using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TItemStockDemand
{
    public int KItemStockDemand { get; set; }

    public Guid? IContext { get; set; }

    public int? KContext { get; set; }

    public int? KWarenLager { get; set; }

    public int? KWarenLagerPlatz { get; set; }

    public int? KWarenLagerBereich { get; set; }

    public int KArtikel { get; set; }

    public decimal FQuantity { get; set; }

    public int KBenutzer { get; set; }

    public string CComment { get; set; } = null!;

    public DateTimeOffset DCreationDate { get; set; }

    public DateTimeOffset? DTargetDate { get; set; }

    public byte NStatus { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TItemStockDemandStatusTransition> TItemStockDemandStatusTransitions { get; set; } = new List<TItemStockDemandStatusTransition>();
}
