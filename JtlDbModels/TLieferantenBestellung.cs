using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantenBestellung
{
    public int KLieferantenBestellung { get; set; }

    public int KLieferant { get; set; }

    public int KSprache { get; set; }

    public int? KLieferantenBestellungRa { get; set; }

    public int? KLieferantenBestellungLa { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public string? CInternerKommentar { get; set; }

    public string? CDruckAnmerkung { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DGemailt { get; set; }

    public DateTime? DGefaxt { get; set; }

    public int? NStatus { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? KFirma { get; set; }

    public int? KLager { get; set; }

    public int? KKunde { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public string? CEigeneBestellnummer { get; set; }

    public string? CBezugsAuftragsNummer { get; set; }

    public int? NDropShipping { get; set; }

    public int? KLieferantenBestellungLieferant { get; set; }

    public int? KBenutzer { get; set; }

    public decimal FFaktor { get; set; }

    public DateTime? DAngemahnt { get; set; }

    public DateTime? DInBearbeitung { get; set; }

    public byte? NDeleted { get; set; }

    public byte? NManuellAbgeschlossen { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public int KLieferschein { get; set; }

    public byte NBestaetigt { get; set; }

    public DateTime? DExportiert { get; set; }

    public byte? NAngelegtDurchWms { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TInboundRef> TInboundRefs { get; set; } = new List<TInboundRef>();

    public virtual ICollection<TLieferavi> TLieferavis { get; set; } = new List<TLieferavi>();
}
