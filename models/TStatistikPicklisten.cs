using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistikPicklisten
{
    public DateTime? DTimeStamp { get; set; }

    public string? CName { get; set; }

    public int? KPicklisteVorlage { get; set; }

    public DateTime? DStartZeit { get; set; }

    public DateTime? DEndZeit { get; set; }

    public int? NAnzahlAuftraege { get; set; }

    public int? DSekunden { get; set; }

    public int? DMilliSec { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
