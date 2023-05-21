using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PickList
{
    public int InternalId { get; set; }

    public int? WarehouseInternalId { get; set; }

    public string? Status { get; set; }

    public string? PickListTemplateName { get; set; }

    public string? Comment { get; set; }

    public DateTime? StatusDate { get; set; }

    public int? StatusUserInternalId { get; set; }

    public DateTime? StatusCreationDate { get; set; }

    public int? UserInternalId { get; set; }

    public DateTime? PrintingDate { get; set; }

    public string? OperationId { get; set; }

    public string? PickListNumber { get; set; }
}
