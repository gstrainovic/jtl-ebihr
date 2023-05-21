using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLotPreparationStock
{
    public int KLotPreparationStock { get; set; }

    public int KLotPreparationComponent { get; set; }

    public int KPicklistePos { get; set; }

    public virtual TLotPreparationComponent KLotPreparationComponentNavigation { get; set; } = null!;

    public virtual TPicklistePo KPicklistePosNavigation { get; set; } = null!;
}
