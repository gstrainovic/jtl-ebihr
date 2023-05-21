using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSetting
{
    public int KSetting { get; set; }

    public string CApplicationName { get; set; } = null!;

    public string CSection { get; set; } = null!;

    public byte NScope { get; set; }

    public string? CHostname { get; set; }

    public int? KBenutzer { get; set; }

    public string CName { get; set; } = null!;

    public string? CDescription { get; set; }

    public string? CValue { get; set; }

    public string? CVersion { get; set; }

    public DateTime DLetzteAenderung { get; set; }

    public int? KBenutzerLetzteAenderung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
