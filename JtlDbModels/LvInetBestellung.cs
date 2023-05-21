using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvInetBestellung
{
    public int KInetBestellung { get; set; }

    public int KShop { get; set; }

    public string? CInetBestNr { get; set; }

    public DateTime? DTimestamp { get; set; }

    public string? CKommentar { get; set; }

    public string? CRechnungVorname { get; set; }

    public string? CRechnungName { get; set; }

    public string? CRechnungFirma { get; set; }

    public string? CRechnungStrasse { get; set; }

    public string? CRechnungPlz { get; set; }

    public string? CRechnungOrt { get; set; }

    public string? CRechnungLand { get; set; }

    public string? CRechnungTel { get; set; }

    public string? CRechnungMail { get; set; }

    public string? CLieferVorname { get; set; }

    public string? CLieferName { get; set; }

    public string? CLieferFirma { get; set; }

    public string? CLieferStrasse { get; set; }

    public string? CLieferPlz { get; set; }

    public string? CLieferOrt { get; set; }

    public string? CLieferLand { get; set; }

    public string? CLieferTel { get; set; }

    public string? CLieferMail { get; set; }

    public int? KInetAdress { get; set; }
}
