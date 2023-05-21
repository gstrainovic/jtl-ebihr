using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerEingangSubset
{
    public int KWarenLagerEingangSubset { get; set; }

    public int KWarenLagerEingang { get; set; }

    public string CSubsetNumber { get; set; } = null!;

    public int FQuantity { get; set; }

    public decimal FFactor { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TWarenLagerEingang KWarenLagerEingangNavigation { get; set; } = null!;

    public virtual ICollection<TWarenLagerEingangSubsetDetail> TWarenLagerEingangSubsetDetails { get; set; } = new List<TWarenLagerEingangSubsetDetail>();
}
