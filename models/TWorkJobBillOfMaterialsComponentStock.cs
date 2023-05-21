using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWorkJobBillOfMaterialsComponentStock
{
    public int KWorkJobBillOfMaterialsComponentStock { get; set; }

    public int KWorkJobBillOfMaterialsComponent { get; set; }

    public int KPicklistePos { get; set; }

    public decimal FActualQuantity { get; set; }

    public int? KMasseinheit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KWorkbenchResource { get; set; }

    public virtual TWorkJobBillOfMaterialsComponent KWorkJobBillOfMaterialsComponentNavigation { get; set; } = null!;

    public virtual TWorkbenchResource? KWorkbenchResourceNavigation { get; set; }
}
