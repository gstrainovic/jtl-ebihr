using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TotalsSalesOrder
{
    /// <summary>
    /// Interne ID des Auftrags
    /// </summary>
    public int SalesOrderInternalId { get; set; }

    /// <summary>
    /// MwSt in Prozent
    /// </summary>
    public decimal Vatrate { get; set; }

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
    /// Gesamtrabattbetrag pro MwSt aufsummiert
    /// </summary>
    public decimal? DiscountValueTotal { get; set; }

    /// <summary>
    /// Bruttopreis der Nachnahmegebühr pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceCodchargeTotal { get; set; }
}
