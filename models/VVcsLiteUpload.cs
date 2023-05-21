using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VVcsLiteUpload
{
    public int KVcsLiteUploadQueue { get; set; }

    public int KExternerBeleg { get; set; }

    public byte NBelegtyp { get; set; }

    public string CBelegnummer { get; set; } = null!;

    public string? CBezugsbelegnummer { get; set; }

    public string COrderId { get; set; } = null!;

    public string CShippingId { get; set; } = null!;

    public string CTransactionId { get; set; } = null!;

    public int KUser { get; set; }

    public int NUploadVersuche { get; set; }

    public byte NStatus { get; set; }

    public int? KFile { get; set; }

    public byte[]? BData { get; set; }

    public DateTime? DFileErstelltUtc { get; set; }

    public string? CFileName { get; set; }
}
