using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLotPreparationProductionOrder
{
    public int KLotPreparationProductionOrder { get; set; }

    public int KProductionOrder { get; set; }

    public virtual TProductionOrder KProductionOrderNavigation { get; set; } = null!;

    public virtual ICollection<TLotPreparationItem> TLotPreparationItems { get; set; } = new List<TLotPreparationItem>();
}
