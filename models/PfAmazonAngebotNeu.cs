using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonAngebotNeu
{
    public string CSellerSku { get; set; } = null!;

    public int KUser { get; set; }

    public string? CName { get; set; }

    public int? NQuantity { get; set; }

    public decimal FPrice { get; set; }

    public string? CProductId { get; set; }

    public byte? NProductIdType { get; set; }

    public byte? NCondition { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGesendet { get; set; }

    public byte? NStatus { get; set; }

    public string? CLetzterFehler { get; set; }

    public int NPlattform { get; set; }

    public string? CConditionNote { get; set; }

    public int KAmazonVersandgruppe { get; set; }

    public int? NBearbeitungszeit { get; set; }

    public int? NMaxBestand { get; set; }

    public int? KArtikel { get; set; }

    public byte? NFulfillmentChannel { get; set; }
}
