using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLotPreparationLot
{
    public int KLotPreparationLot { get; set; }

    public int KLotPreparationItem { get; set; }

    public int NLotIndex { get; set; }

    public int? KResource { get; set; }

    public DateTime? DShelfLifeEndDate { get; set; }

    public bool NIsShelfLifeEndDateModifiable { get; set; }

    public string? CBatchNumber { get; set; }

    public bool NIsBatchNumberModifiable { get; set; }

    public int? KPickliste { get; set; }

    public virtual TLotPreparationItem KLotPreparationItemNavigation { get; set; } = null!;

    public virtual TPickliste? KPicklisteNavigation { get; set; }

    public virtual TResource? KResourceNavigation { get; set; }

    public virtual ICollection<TLotPreparationComponent> TLotPreparationComponents { get; set; } = new List<TLotPreparationComponent>();
}
