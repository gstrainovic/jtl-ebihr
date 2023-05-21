using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistikEazyShipping
{
    public DateTime? DTimeStamp { get; set; }

    public int? KBestellung { get; set; }

    public DateTime? DStartZeit { get; set; }

    public DateTime? DEndZeit { get; set; }

    public int? NAnzahlWmspackItem { get; set; }

    public int? NAnzahlWmspackItemData { get; set; }

    public int? NAnzahlWarenlagerAusgaenge { get; set; }

    public int? DSekunden { get; set; }

    public int? DMilliSec { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
