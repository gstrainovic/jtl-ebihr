using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VUploadMetaDatum
{
    public int KUploadData { get; set; }

    public int KOrder { get; set; }

    public byte NType { get; set; }

    public string CSellerId { get; set; } = null!;

    public string? CExterneAuftragsnummer { get; set; }

    public string CRechnungsnr { get; set; } = null!;

    public string CChannel { get; set; } = null!;

    public int KAuftrag { get; set; }

    public int KRechnung { get; set; }
}
