using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderPayment
{
    public int? KOrder { get; set; }

    public int KPayment { get; set; }

    public string? CPaymentMethodName { get; set; }

    public decimal FAmount { get; set; }

    public string? CExternalTransactionId { get; set; }

    public string? CNote { get; set; }

    public byte NType { get; set; }
}
