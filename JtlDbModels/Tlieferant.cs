using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tlieferant
{
    public int KLieferant { get; set; }

    public string? CLiefNr { get; set; }

    public string? CFirma { get; set; }

    public string? CKontakt { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CTelZentralle { get; set; }

    public string? CTelDurchwahl { get; set; }

    public string? CFax { get; set; }

    public string? CEmail { get; set; }

    public string? CWww { get; set; }

    public string? CAnmerkung { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CAktiv { get; set; }

    public string? CUstid { get; set; }

    public string? CIso { get; set; }

    public int? KSprache { get; set; }

    public string? CStatus { get; set; }

    public string? CLieferantId { get; set; }

    public int? NKreditorennr { get; set; }

    public string? CWaehrungIso { get; set; }

    public byte? NVstfrei { get; set; }

    public string? CExterneDatenUrl { get; set; }

    public byte? NDropshipping { get; set; }

    public int? NLieferzeit { get; set; }

    public int? NZahlungsziel { get; set; }

    public decimal FSkonto { get; set; }

    public decimal FMindestbestellwert { get; set; }

    public decimal FMindermengenzuschlag { get; set; }

    public decimal FFrachtkosten { get; set; }

    public decimal FVersandfreiAb { get; set; }

    public string? CHinweisLieferbedingung { get; set; }

    public string? CFirmenZusatz { get; set; }

    public string? CAdresszusatz { get; set; }

    public string? CBundesland { get; set; }

    public int? NSkontoTage { get; set; }

    public byte? NStaffelPreisProBestellung { get; set; }

    public byte? NKeineEinkaufsliste { get; set; }

    public string? CAnrede { get; set; }

    public string? CVorname { get; set; }

    public string? CNachname { get; set; }

    public byte NDropshippingBeiNachnahme { get; set; }

    public int NStandardFirma { get; set; }

    public int NStandardLager { get; set; }

    public decimal FMwStFreiposition { get; set; }

    public byte NDropshippingFreipositionen { get; set; }

    public byte? NJtlFulfillment { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NType { get; set; }

    public virtual ICollection<TTicket> TTickets { get; set; } = new List<TTicket>();

    public virtual ICollection<Tliefartikel> Tliefartikels { get; set; } = new List<Tliefartikel>();
}
