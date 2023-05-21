using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class ShippingNotification
{
    public int InternalId { get; set; }

    public int SalesOrderInternalId { get; set; }

    public int UserInternalId { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? Note { get; set; }

    public int? PurchaseOrderInternalId { get; set; }

    public string? DeliveryNoteText { get; set; }

    public int? CompanyInternalId { get; set; }

    public string SalesOrderNumber { get; set; } = null!;

    public string? CustomerNumber { get; set; }

    public int? CustomerInternalId { get; set; }

    public int? FulfilmentOrderInternalId { get; set; }

    public DateTime? MailingDate { get; set; }
}
