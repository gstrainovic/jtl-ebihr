using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkJobBillOfMaterialsComponent
{
    public int KWorkJobBillOfMaterialsComponent { get; set; }

    public int KWorkJobOperation { get; set; }

    public decimal? FActualQuantity { get; set; }

    public decimal? FTargetQuantity { get; set; }

    public int KArtikel { get; set; }

    public int? KOriginBillOfMaterialComponent { get; set; }

    public int? KMasseinheit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TBillOfMaterialComponent? KOriginBillOfMaterialComponentNavigation { get; set; }

    public virtual TWorkJobOperation KWorkJobOperationNavigation { get; set; } = null!;

    public virtual ICollection<TWorkJobBillOfMaterialsComponentStock> TWorkJobBillOfMaterialsComponentStocks { get; set; } = new List<TWorkJobBillOfMaterialsComponentStock>();
}
