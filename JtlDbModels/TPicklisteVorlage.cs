using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlage
{
    public int KPicklisteVorlage { get; set; }

    public int? KPickliste { get; set; }

    public byte? NIstVorlage { get; set; }

    public int? NAnzahlBestellungen { get; set; }

    public int? KBestellNr { get; set; }

    public int? NAnzahlArtikelAuftragMax { get; set; }

    public int? NAnzahlArtikelAuftragMin { get; set; }

    public byte? NTeillieferungen { get; set; }

    public decimal FTeillieferungenWert { get; set; }

    public int? NBoxenVon { get; set; }

    public int? NBoxenBis { get; set; }

    public decimal FGewichtVon { get; set; }

    public decimal FGewichtBis { get; set; }

    public byte? NSortierung { get; set; }

    public string? CKommentar { get; set; }

    public DateTime? DVonDatum { get; set; }

    public DateTime? DBisDatum { get; set; }

    public int? KBenutzer { get; set; }

    public DateTime? DAngelegt { get; set; }

    public string? CVersandartNr { get; set; }

    public string? CShops { get; set; }

    public string? CPlattformen { get; set; }

    public int? KWarenlager { get; set; }

    public string? CName { get; set; }

    public int? NQuickSlot { get; set; }

    public string? CWarengruppen { get; set; }

    public int? KRollendeKommissionierungPickwagen { get; set; }

    public byte? NBestellungWmsfreigabe { get; set; }

    public int NMaxAnzahlArtikel { get; set; }

    public byte? NNichtBezahltVorkommissionieren { get; set; }

    public byte? NNichtBezahltAutomatischAufVorkommi { get; set; }

    public string? CLieferlaender { get; set; }

    public string? CLagerbereiche { get; set; }

    public decimal FPreisAuftragMax { get; set; }

    public decimal FPreisAuftragMin { get; set; }

    public string? CAuftragkennzeichnung { get; set; }

    public string? CFirmen { get; set; }

    public string? CKundengruppen { get; set; }

    public string? CVersandklassen { get; set; }

    public string? CZahlungsarten { get; set; }

    public byte NEnthaeltArtAusWarengruppe { get; set; }

    public byte NAlleOhneWarengruppe { get; set; }

    public byte NAlleOhneVersandart { get; set; }

    public byte NAlleOhneZahlungsart { get; set; }

    public byte NDirektVerpacken { get; set; }

    public string? CBenutzer { get; set; }

    public byte NSortenrein { get; set; }

    public byte NAuftragsArt { get; set; }

    public byte NMhdhandling { get; set; }

    public int NMhdminHaltbarkeit { get; set; }

    public int NArtikelBreiteVon { get; set; }

    public int NArtikelBreiteBis { get; set; }

    public int NArtikelHoeheVon { get; set; }

    public int NArtikelHoeheBis { get; set; }

    public int NArtikelLaengeVon { get; set; }

    public int NArtikelLaengeBis { get; set; }

    public byte NBoxenNurGanzeStuecklistenAufPl { get; set; }

    public long NAuftragsVolumenVon { get; set; }

    public long NAuftragsVolumenBis { get; set; }

    public byte NOhneVolumenAusschliessen { get; set; }

    public byte NStuecklisteVonGleichenPlatz { get; set; }

    public byte NMobileAppPicklistenVorlage { get; set; }

    public byte NNachschubPickenLast { get; set; }

    public byte NPlatzPrioBeruecksichtigen { get; set; }

    public int? KPicklistenVorlageUrsprung { get; set; }

    public byte NEnthaeltArtAusEigeneFelder { get; set; }

    public byte NEnthaeltArtArtikelZustand { get; set; }

    public byte NNurAusgewaehlteVersandartenAnzeigen { get; set; }

    public string? CAuftragsPrio { get; set; }

    public byte NStuecklisteNurWennAlleAufPlatz { get; set; }

    public byte NAngebrocheneBoxenImmerVervollstaendigen { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CColor { get; set; }

    public int NAnzahlBestellungenMin { get; set; }

    public string? CPlatzTypen { get; set; }

    public byte? NPicklistenVorlageTyp { get; set; }

    public int? KVorlagenSet { get; set; }

    public byte NAlleOhneHersteller { get; set; }

    public byte NEnthaeltHersteller { get; set; }

    public string? CAuftragsFarben { get; set; }

    public byte NAlleOhneFarben { get; set; }

    public byte NAdressenCheck { get; set; }

    public int KWarenlagerUmlagerung { get; set; }

    public byte NAlleOhneLagerbereich { get; set; }

    public byte NKeineOderAlleInLagerbereich { get; set; }

    public string? CVorlageSerialized { get; set; }

    public int? NReservierungsFehler { get; set; }

    public string? CRechnungslaender { get; set; }

    public string? CBenutzerAuftrag { get; set; }

    public byte? NBenutzerAuftragAusschliessen { get; set; }

    public byte NAutomatischErstellen { get; set; }

    public byte NEnthaeltAuftragAusEigeneFelder { get; set; }

    public int NArtikelKuerzesteKanteMax { get; set; }

    public int NArtikelKuerzesteKanteMin { get; set; }

    public int NArtikelLaengsteKanteMax { get; set; }

    public int NArtikelLaengsteKanteMin { get; set; }

    public int NAutomatischErstellenMaxAnzahl { get; set; }

    public byte? NAuftraegeChargenrein { get; set; }

    public int? NSortenreinMaxAnzahlArtikel { get; set; }

    public int NMinAnzahlArtikel { get; set; }

    public int NLagerplatzNachMenge { get; set; }

    public byte NVollstaengigeImmerVorkommissionieren { get; set; }

    public byte NKeineAuftraegeVollstaendigAufPickliste { get; set; }

    public byte NPicklisteFuerBenutzerAusblenden { get; set; }

    public byte? NArtikelLabelFilterModus { get; set; }

    public int? KPicklisteVorlageParent { get; set; }

    public byte NPlaetzeOhneReservierungZuerst { get; set; }

    public byte NVorschauDeaktiv { get; set; }

    public decimal NArtikelEinzelPreisMin { get; set; }

    public decimal NArtikelEinzelPreisMax { get; set; }

    public byte NVollstaendigTeilgeliefertFifo { get; set; }

    public short NTreeSort { get; set; }
}
