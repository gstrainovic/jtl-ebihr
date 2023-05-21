using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfUser
{
    public int KUser { get; set; }

    public int? KFirma { get; set; }

    public string? CAuthToken { get; set; }

    public string? CId1 { get; set; }

    public string? CId2 { get; set; }

    public string? CId3 { get; set; }

    public string? CName { get; set; }

    public int NPlattform { get; set; }

    public int? NAktiv { get; set; }

    public int? KSprache { get; set; }

    public int? KBenutzer { get; set; }

    public int? NZahlung { get; set; }

    public string? CVersandName { get; set; }

    public int? NBenutzePosName { get; set; }

    public DateTime? DInventardaten { get; set; }

    public DateTime? DInventardatenFba { get; set; }

    public int? NVersandpos0 { get; set; }

    public int? NAnmerkung { get; set; }

    public string? CAnmerkung { get; set; }

    public int? NLagerSenden { get; set; }

    public byte? NRepricing { get; set; }

    public DateTime? DRepricingFull { get; set; }

    public byte? NEu { get; set; }

    public byte? NFbalagerAbziehen { get; set; }

    public int? KVersandartStandard { get; set; }

    public int? KVersandartExpedited { get; set; }

    public byte? NFbaversandmailAnKunde { get; set; }

    public string? CFbaversandmailKopie { get; set; }

    public byte? NIgnorierePaymentsBestellungen { get; set; }

    public string? CFbakommentar { get; set; }

    public int? KZahlungsart { get; set; }

    public string? CAmazonAuthToken { get; set; }

    public int KVersandartNextDayNonPrime { get; set; }

    public int KVersandartSecondDayNonPrime { get; set; }

    public int KVersandartPrimeStandard { get; set; }

    public int? KKundengruppe { get; set; }

    public byte NBearbeitungszeitAnpassen { get; set; }

    public byte NInventardatenAnfordern { get; set; }

    public byte NBearbeitungszeitAufschlag { get; set; }

    public DateTime? DStartVcs { get; set; }

    public int KColorFbaOrder { get; set; }

    public int KColorSellerFulfilledPrimeOrder { get; set; }

    public int KColorB2border { get; set; }

    public int KColorCustomOrder { get; set; }

    public int KColorFbaAndB2border { get; set; }

    public int KColorSellerFulfilledPrimeAndCustomOrder { get; set; }

    public bool? NSendPriceAdjustment { get; set; }

    public byte NVcsmodus { get; set; }

    public bool NIsTerminated { get; set; }

    public DateTime? DTrailPeriodEndAt { get; set; }

    public string? CRegion { get; set; }

    public long NLastVcsLiteId { get; set; }

    public byte? NVcsLiteRequestForLastDays { get; set; }

    public bool? NBestandInitialSetzen { get; set; }

    public bool NAmazonCustomDataLaden { get; set; }

    public byte NAmazonCustomDataType { get; set; }

    public string? CAmazonCustomDataPath { get; set; }

    public virtual ICollection<TAmazonAngebotFehler> TAmazonAngebotFehlers { get; set; } = new List<TAmazonAngebotFehler>();

    public virtual ICollection<TAmazonTask> TAmazonTasks { get; set; } = new List<TAmazonTask>();

    public virtual ICollection<TAuftrag> TAuftrags { get; set; } = new List<TAuftrag>();

    public virtual ICollection<TBestelldatumLand> TBestelldatumLands { get; set; } = new List<TBestelldatumLand>();

    public virtual ICollection<TExterneRechnung> TExterneRechnungs { get; set; } = new List<TExterneRechnung>();

    public virtual ICollection<TMarktplatz> TMarktplatzs { get; set; } = new List<TMarktplatz>();
}
