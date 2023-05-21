using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayItemDuplicateLog
{
    public int KLog { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public int KAngebotItem { get; set; }

    public string? CAngebotItemId { get; set; }

    public byte? NAngebotStatus { get; set; }

    public DateTime? DAngebotStartTime { get; set; }

    public DateTime? DAngebotEndTime { get; set; }

    public int KVorlageItem { get; set; }

    public byte? NVorlageAutomatischEinstellen { get; set; }

    public string? CVorlageListingDuration { get; set; }

    public int KAnderesAngebotItem { get; set; }

    public string? CAnderesAngebotItemId { get; set; }

    public byte? NAnderesAngebotStatus { get; set; }

    public DateTime? DAnderesAngebotStartTime { get; set; }

    public DateTime? DAnderesAngebotEndTime { get; set; }
}
