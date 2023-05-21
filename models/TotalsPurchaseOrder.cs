using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TotalsPurchaseOrder
{
    /// <summary>
    /// Interne ID der Lieferantenbestellung
    /// </summary>
    public int PurchaseOrderInternalId { get; set; }

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
    /// Bruttopreis des Versandzuschlags pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceShippingSurchargeTotal { get; set; }

    /// <summary>
    /// Nettopreis des Versandzuschlags pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceShippingSurchargeTotal { get; set; }

    /// <summary>
    /// Bruttopreis des Rabatts pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceDiscountTotal { get; set; }

    /// <summary>
    /// Nettopreis des Rabatts pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceDiscountTotal { get; set; }

    /// <summary>
    /// Bruttopreis des Mindermengenzuschlags pro MwSt aufsummiert
    /// </summary>
    public decimal? GrossPriceMinimumQuantitySurchargeTotal { get; set; }

    /// <summary>
    /// Nettopreis des Mindermengenzuschlags pro MwSt aufsummiert
    /// </summary>
    public decimal? NetPriceMinimumQuantitySurchargeTotal { get; set; }

    /// <summary>
    /// MwSt der Versandkosten pro MwSt aufsummiert
    /// </summary>
    public decimal? ShippingCostsVat { get; set; }
}
