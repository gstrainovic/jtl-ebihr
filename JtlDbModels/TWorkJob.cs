using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkJob
{
    public int KWorkJob { get; set; }

    public int? KSessionId { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public int KBenutzer { get; set; }

    public byte NType { get; set; }

    public int KBillOfMaterial { get; set; }

    public decimal NLotSize { get; set; }

    public decimal FMultiplier { get; set; }

    public decimal FEkNetto { get; set; }

    public int KArtikel { get; set; }

    public int? KWorkProcessIteration { get; set; }

    public int? KProductionOrderProducible { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal FActualQuantity { get; set; }

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;

    public virtual TBillOfMaterial KBillOfMaterialNavigation { get; set; } = null!;

    public virtual TProductionOrderProducible? KProductionOrderProducibleNavigation { get; set; }

    public virtual TSessionId? KSession { get; set; }

    public virtual TWorkProcessIteration? KWorkProcessIterationNavigation { get; set; }

    public virtual ICollection<TWorkJobOperation> TWorkJobOperations { get; set; } = new List<TWorkJobOperation>();

    public virtual ICollection<TWorkJobResult> TWorkJobResults { get; set; } = new List<TWorkJobResult>();

    public virtual ICollection<TDisposition> KDispositions { get; set; } = new List<TDisposition>();
}
