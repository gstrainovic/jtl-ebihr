using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWarenLagerOptionen
{
    public int KWarenLagerOptionen { get; set; }

    public int KWarenLager { get; set; }

    public byte? NEinlagerwagenVerwenden { get; set; }

    public int? NWedirektBuchenAktiv { get; set; }

    public int? KWarenLagerPlatzEingang { get; set; }

    public byte? NUseScannerImWe { get; set; }

    public int? KWarenlagerPlatzBoxen { get; set; }

    public int? NWadirektAusWe { get; set; }

    public int? NWadirektAusWe1artikel { get; set; }

    public int? NRollendeKommissionierung { get; set; }

    public int? NEazyShipping { get; set; }

    public int? NUeberlieferung { get; set; }

    public int? NUeberlieferungNachfragen { get; set; }

    public byte? NScanInMehrereArtikel { get; set; }

    public byte? NVersandboxenProzess { get; set; }

    public byte? NVersandboxenProzessmitRoKo { get; set; }

    public byte? NChargen { get; set; }

    public byte? NMhd { get; set; }

    public byte? NWadirektAusWeauchLeereBoxenBelegen { get; set; }

    public byte? NWeneuenArtikelAnlegen { get; set; }

    public int? KKategorieNeuerArtikel { get; set; }

    public byte? NWeoffeneBestellungsmengenZeigen { get; set; }

    public byte? NVerpackenMehrMengeErlaubt { get; set; }

    public byte? NWadirektAusWeauchLeereBoxenBelegenZulauf { get; set; }

    public byte? NLagerKleinerNullImWesetzen { get; set; }

    public byte? NVerpackenBestellhinweis { get; set; }

    public byte? NVerpackenAnmerkung { get; set; }

    public int? KWarenlagerPlatzInBearbeitung { get; set; }

    public byte NAbgelaufenesMhdnichtEinbuchen { get; set; }

    public byte NPackHinweisVorVerpacken { get; set; }

    public byte NGanzeBestellungVerpackenInEazyShip { get; set; }

    public byte NMengeBestaetigen { get; set; }

    public byte? NWadirektAusWeauchLeereBoxenBelegenFreiProzent { get; set; }

    public byte? NWemengeInArtField { get; set; }

    public byte? NBesondereWeplaetze { get; set; }

    public byte NNumPad { get; set; }

    public byte NPickenOhneScan { get; set; }

    public byte NKeineLiefNachfrage { get; set; }

    public byte NWaversandartScan { get; set; }

    public byte NEazyShippingArtikelDetails { get; set; }

    public byte NEazyShippingKeinenRechnungOhneDruck { get; set; }

    public byte NEazyShippingKeineRechnungBeiNullEuro { get; set; }

    public byte NKommentarPflichtKorrekturbuchung { get; set; }

    public byte? NArtikelAttributeBeachten { get; set; }

    public byte? NBoxenDirektTauschen { get; set; }

    public byte NEazyShippingArtikelButtons { get; set; }

    public byte NEazyShippingFreiposButtons { get; set; }

    public byte? NVersandBoxenScan { get; set; }

    public byte? NVersandBoxenButtons { get; set; }

    public byte? NVersandBoxenFreiPosButtons { get; set; }

    public byte? NBoxenFuellenBestaetigen { get; set; }

    public int? NAutoAbmelden { get; set; }

    public int? NEazyShippingSplittAuftrag { get; set; }

    public byte? NWeaufVorgabeplatz { get; set; }

    public byte? NArtikelAnmerkungenPackhinweis { get; set; }

    public byte? NPacktischMhdchargeNichtScannen { get; set; }

    public byte NMobilerPacktischKeinenRechnungOhneDruck { get; set; }

    public byte NMobilerPacktischKeineRechnungBeiNullEuro { get; set; }

    public byte NGanzeBestellungVerpackenNurPickInEazyShip { get; set; }

    public byte NMobilerPacktischMengeBestaetigen { get; set; }

    public byte NAllePackHinweiseAlsPopUp { get; set; }

    public int? KWarenLagerPlatzRetoure { get; set; }

    public int? NRetourenPlatzManuellWaehlen { get; set; }

    public byte NWefremdeWarenlagerAnzeigen { get; set; }

    public byte NArtikelBezeichnungAusArtikel { get; set; }

    public byte NWeinLeereBoxenNurBeiVorkomm { get; set; }

    public byte NWaverpackteArtikelNachUnten { get; set; }

    public int? NBoxenDruckAusAuftragsVorlage { get; set; }

    public bool? NRetoureAufVorgabeplatz { get; set; }

    public byte NWahintDisappearAfterXseconds { get; set; }

    public byte NWePlatzSortierung { get; set; }

    public byte NMobilerPacktischGebindeScanForArtikel { get; set; }

    public byte NFreierWeLieferantenArtikelAutoZuordnung { get; set; }

    public byte NFreierWeEkunbekanntHandling { get; set; }

    public byte NWesortArtikelByEinbuchdatum { get; set; }

    public byte NBoxenSplittAuftrag { get; set; }

    public byte NBoxenKeinenRechnungOhneDruck { get; set; }

    public byte NBoxenKeineRechnungBeiNullEuro { get; set; }

    public byte NKommentarPflichtInventur { get; set; }

    public byte NKommentarPflichtArtikelZustandAendern { get; set; }

    public byte NNachschubNurBezahlteAuftraege { get; set; }

    public byte NMobilerPacktisch { get; set; }

    public int NKundeEigenesFeld { get; set; }

    public byte NWadirektWe1artikelMengenCheck { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NFirstMobileAppPicklistenVorlageVerwenden { get; set; }

    public byte NMassenauslieferung { get; set; }

    public byte NMassenauslieferungPicklisteDrucken { get; set; }

    public int NMassenauslieferungMinGleicheAuftraege { get; set; }

    public int NSelectPlatzByTouch { get; set; }

    public byte NCreateInventurMobile { get; set; }

    public int NCreateInventurMobilePlatz { get; set; }

    public int NCreateInventurMobilePeriod { get; set; }

    public int NCreateInventurMobileInterval { get; set; }

    public byte NCreateInventurMobileNumberOfPlatzManuel { get; set; }

    public int NCreateInventurMobileNumberOfPlatzDefault { get; set; }

    public int KWarenLagerPlatzEingangDefaultMobile { get; set; }

    public byte NPoolRoKo { get; set; }

    public byte NTeilrechnungEazyshipping { get; set; }

    public byte NTeilrechnungBoxen { get; set; }

    public byte NTeilrechnungMoPa { get; set; }

    public byte NWareingangBestellungAnzeigen { get; set; }

    public byte NWareneingangOhneScan { get; set; }

    public byte NNachschubOhneScan { get; set; }

    public byte NLagerplatzBestaetigen { get; set; }

    public bool NTeilmengen { get; set; }

    public byte NTeillieferbarUmlagern { get; set; }

    public byte NIdentischeAuftraegeMitTeillieferung { get; set; }

    public byte NWehinweisArtikelAnmerkung { get; set; }

    public int NWehinweisArtikelEigenesFeld { get; set; }

    public byte NPickHinweisArtikelAnmerkung { get; set; }

    public int NPickHinweisArtikelEigenesFeld { get; set; }

    public byte NVersandHinweisConfirmEnabled { get; set; }

    public byte NKartonagenabfrageVerpflichtend { get; set; }

    public byte NMhdchargeAnywhere { get; set; }

    public byte NMixMhdChargen { get; set; }

    public bool NMhdChargenOnDifferendPlatzen { get; set; }

    public bool NPartialPickEnabled { get; set; }

    public byte NMobileInventurOhneVorladen { get; set; }
}
