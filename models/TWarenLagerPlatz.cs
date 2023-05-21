using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerPlatz
{
    public int KWarenLagerPlatz { get; set; }

    public int KWarenLager { get; set; }

    public decimal FGewichtMax { get; set; }

    public string? CKommentar { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public int? KWarenLagerPlatzTyp { get; set; }

    public int NStatus { get; set; }

    public DateTime? DWmsInventurDatum { get; set; }

    public int? KWmsInventur { get; set; }

    public int? NPreInvStatus { get; set; }

    public byte? NInvGezaehlt { get; set; }

    public byte NGesperrt { get; set; }

    public int NPrio { get; set; }

    public bool NAuslieferungGesperrt { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TWarehouseBinDevice> TWarehouseBinDevices { get; set; } = new List<TWarehouseBinDevice>();

    public virtual ICollection<TWorkbenchBin> TWorkbenchBins { get; set; } = new List<TWorkbenchBin>();
}
