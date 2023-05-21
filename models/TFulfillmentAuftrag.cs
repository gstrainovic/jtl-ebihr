using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFulfillmentAuftrag
{
    public int KFulfillmentAuftrag { get; set; }

    public int? KLieferschein { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferadresse { get; set; }

    public int? KWarenlager { get; set; }

    public int? KUser { get; set; }

    public int? KBenutzer { get; set; }

    public int? KSprache { get; set; }

    public int? NFulfillmentDienstleister { get; set; }

    public int? NStatus { get; set; }

    public string? CBestellnummer { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? CKommentar { get; set; }

    public string? CLieferAdresseKundennummer { get; set; }

    public string? CLieferAdresseFirma { get; set; }

    public string? CLieferAdresseAnrede { get; set; }

    public string? CLieferAdresseTitel { get; set; }

    public string? CLieferAdresseVorname { get; set; }

    public string? CLieferAdresseName { get; set; }

    public string? CLieferAdresseStrasse { get; set; }

    public string? CLieferAdressePlz { get; set; }

    public string? CLieferAdresseOrt { get; set; }

    public string? CLieferAdresseLand { get; set; }

    public string? CLieferAdresseTel { get; set; }

    public string? CLieferAdresseFax { get; set; }

    public string? CLieferAdresseEmail { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DGemailt { get; set; }

    public DateTime? DGefaxt { get; set; }

    public DateTime? DApiVersendet { get; set; }

    public DateTime? DInBearbeitung { get; set; }

    public string? CLieferPrioritaet { get; set; }

    public DateTime? DBestelldatum { get; set; }

    public string? CLieferAdressZusatz { get; set; }

    public string? CLieferZusatz { get; set; }

    public string? CFehlermeldung { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? COutboundId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CStornoCode { get; set; }

    public string? CStornoGrund { get; set; }

    public virtual TDeliveryQueue? TDeliveryQueue { get; set; }

    public virtual ICollection<TOutboundRef> TOutboundRefs { get; set; } = new List<TOutboundRef>();
}
