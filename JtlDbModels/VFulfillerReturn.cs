using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VFulfillerReturn
{
    public int KRmRetoure { get; set; }

    public string RetoureNr { get; set; } = null!;

    public DateTime DErstellt { get; set; }

    public int KRmretoureAbholAdresse { get; set; }

    public string? KommentarExtern { get; set; }

    public string? KommentarIntern { get; set; }

    public string? Ansprechpartner { get; set; }

    public string? WarehouseId { get; set; }

    public string? MerchantId { get; set; }

    public string? ReturnId { get; set; }

    public string? ReturnReferenceWarehouseId { get; set; }
}
