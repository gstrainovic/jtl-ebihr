using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VShop
{
    public int KShopScx { get; set; }

    public int KShop { get; set; }

    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public DateTime DCreated { get; set; }

    public DateTime? DUpdated { get; set; }

    public string? CReason { get; set; }

    public int? KVersandart { get; set; }

    public string? CName { get; set; }

    public byte? NGesperrt { get; set; }

    public bool NAktiv { get; set; }

    public int? KFirma { get; set; }

    public byte NTyp { get; set; }

    public string CChannelDisplayName { get; set; } = null!;

    public string CChannelCurrency { get; set; } = null!;

    public bool NVariationsSupported { get; set; }

    public bool NRemainingQuantitySupported { get; set; }

    public bool NQuantityPriceSupported { get; set; }

    public byte NInvoiceDocumentTransfer { get; set; }

    public DateTime? DKategorieAktualisierungUtc { get; set; }

    public DateTime? DChannelAttributeAktualisierungUtc { get; set; }

    public DateTime? DSellerAttributeAktualisierungUtc { get; set; }
}
