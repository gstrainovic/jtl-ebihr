using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvBestellung
{
    public int KBestellung { get; set; }

    public string? CBestellnummer { get; set; }

    public DateTime? DErstellt { get; set; }

    public int KLieferant { get; set; }

    public string CLieferantName { get; set; } = null!;

    public string CLieferantennummer { get; set; } = null!;

    public string CLieferantFirmenZusatz { get; set; } = null!;

    public string CLieferantEigeneKundennummer { get; set; } = null!;

    public int NStatus { get; set; }

    public byte? NManuellAbgeschlossen { get; set; }

    public DateTime? DGemailt { get; set; }

    public DateTime? DGefaxt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DAngemahnt { get; set; }

    public string? CInternerKommentar { get; set; }

    public string? CFremdbelegnummer { get; set; }

    public byte NBestaetigt { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public string? CDruckAnmerkung { get; set; }

    public string CWarenLagerName { get; set; } = null!;

    public DateTime? DExportiert { get; set; }

    public string? CBenutzerName { get; set; }

    public string? CBezugsAuftragsNummer { get; set; }

    public decimal FSummePositionenNetto { get; set; }

    public decimal FSummePositionenBrutto { get; set; }

    public int NAnzahlPositionen { get; set; }

    public decimal FMengeGeliefert { get; set; }

    public decimal FProzentGeliefert { get; set; }

    public decimal FGesamtmenge { get; set; }

    public string CKundenNr { get; set; } = null!;

    public string CKundeFirma { get; set; } = null!;

    public string CKundeVorname { get; set; } = null!;

    public string CKundeName { get; set; } = null!;

    public string CLieferadresseFirma { get; set; } = null!;

    public string CLieferadresseVorname { get; set; } = null!;

    public string CLieferadresseName { get; set; } = null!;

    public string CLieferadressePlz { get; set; } = null!;

    public string CLieferadresseOrt { get; set; } = null!;

    public string CLieferadresseLand { get; set; } = null!;

    public string CLieferadresseStrasse { get; set; } = null!;

    public string CLieferadresseMail { get; set; } = null!;

    public string CRechnungsadresseFirma { get; set; } = null!;

    public string CRechnungsadresseVorname { get; set; } = null!;

    public string CRechnungsadresseName { get; set; } = null!;

    public int? NAlterBestellung { get; set; }

    public string CLieferanschrift { get; set; } = null!;

    public int NHasEingangsrechnung { get; set; }

    public int NIstUeberfaellig { get; set; }

    public int? KInboundRef { get; set; }
}
