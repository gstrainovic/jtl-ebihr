using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLotPreparationItem
{
    public int KLotPreparationItem { get; set; }

    public int KLotPreparationProductionOrder { get; set; }

    public int KProductionOrderProducible { get; set; }

    public virtual TLotPreparationProductionOrder KLotPreparationProductionOrderNavigation { get; set; } = null!;

    public virtual TProductionOrderProducible KProductionOrderProducibleNavigation { get; set; } = null!;

    public virtual ICollection<TLotPreparationLot> TLotPreparationLots { get; set; } = new List<TLotPreparationLot>();
}
