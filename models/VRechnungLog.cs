using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRechnungLog
{
    public int KRechnungLog { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public byte NLogTyp { get; set; }

    public string CLogTyp { get; set; } = null!;

    public int KRechnung { get; set; }

    public string? CRechnungsNr { get; set; }

    public string CAppName { get; set; } = null!;

    public string? CXml { get; set; }

    public byte[]? BXml { get; set; }

    public byte[] BRowVersion { get; set; } = null!;

    public byte[]? BLastRowVersion { get; set; }

    public long? NLogAbstand { get; set; }

    public string? CPrüfStatus { get; set; }
}
