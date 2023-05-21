using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFulfillmentKunde
{
    public int KKunde { get; set; }

    public string? CKundenNr { get; set; }

    public string? CFirma { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CIso { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CEmail { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CMobil { get; set; }

    public int? KKundenGruppe { get; set; }

    public string? CBundesland { get; set; }

    public int? KKundenKategorie { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CZusatz { get; set; }

    public string? CPostId { get; set; }

    public string? CKategorie { get; set; }

    public string? CFulfillmentSupplierId { get; set; }

    public int KLieferant { get; set; }

    public int NStandardFirma { get; set; }

    public int KFulfillerEinstellungen { get; set; }

    public string? CPrefixAbrechnung { get; set; }

    public string? CSuffixAbrechnung { get; set; }

    public byte NAbrechnungsZeitraum { get; set; }

    public int KAbrechnung { get; set; }

    public DateTime DAbrechnungInitial { get; set; }

    public DateTime DAbrechnungStart { get; set; }

    public DateTime DAbrechnungEnde { get; set; }

    public int? NBestandserfassungModus { get; set; }

    public byte KKundeFirma { get; set; }
}
