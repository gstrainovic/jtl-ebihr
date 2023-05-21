using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProductionOrderProducible
{
    public int KProductionOrderProducible { get; set; }

    public int KProductionOrder { get; set; }

    public int KArtikel { get; set; }

    public decimal FTargetTotalQuantity { get; set; }

    public int KBillOfMaterial { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal FLotSize { get; set; }

    public decimal FActualQuantity { get; set; }

    public int? KDisposition { get; set; }

    public virtual TProdItem KArtikelNavigation { get; set; } = null!;

    public virtual TBillOfMaterial KBillOfMaterialNavigation { get; set; } = null!;

    public virtual TDisposition? KDispositionNavigation { get; set; }

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;

    public virtual TLotPreparationItem? TLotPreparationItem { get; set; }

    public virtual ICollection<TWorkJob> TWorkJobs { get; set; } = new List<TWorkJob>();
}
