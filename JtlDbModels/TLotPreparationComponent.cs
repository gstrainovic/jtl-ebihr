using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLotPreparationComponent
{
    public int KLotPreparationComponent { get; set; }

    public int KLotPreparationLot { get; set; }

    public int KBillOfMaterialComponent { get; set; }

    public virtual TBillOfMaterialComponent KBillOfMaterialComponentNavigation { get; set; } = null!;

    public virtual TLotPreparationLot KLotPreparationLotNavigation { get; set; } = null!;

    public virtual ICollection<TLotPreparationStock> TLotPreparationStocks { get; set; } = new List<TLotPreparationStock>();
}
