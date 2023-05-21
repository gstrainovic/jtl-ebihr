using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TotalsInvoiceCorrection
{
    /// <summary>
    /// Interne ID der Rechnungskorrektur
    /// </summary>
    public int InvoiceCorrectionInternalId { get; set; }

    /// <summary>
    /// MwSt in Prozent
    /// </summary>
    public decimal? Vatrate { get; set; }

    /// <summary>
    /// Summe der MwSt 
    /// </summary>
    public decimal? Vatsum { get; set; }

    /// <summary>
    /// Gesamtbruttopreis pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceTotal { get; set; }

    /// <summary>
    /// GesamtNettopreis pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceTotal { get; set; }

    /// <summary>
    /// Bruttopreis der Versandposition pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceShippingPositionTotal { get; set; }

    /// <summary>
    /// Nettopreis der Versandposition pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceShippingPositionTotal { get; set; }

    /// <summary>
    /// MwSt der Versandkosten pro MwSt aufsummiert
    /// </summary>
    public decimal? ShippingCostsVat { get; set; }

    /// <summary>
    /// Bruttopreis des Rabatts pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceDiscountTotal { get; set; }

    /// <summary>
    /// Nettopreis des Rabatts pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceDiscountTotal { get; set; }
}
