using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAmazonTask
{
    public int KAmazonTask { get; set; }

    public string CSku { get; set; } = null!;

    public int NPlattform { get; set; }

    public int KAmazonStrategieAuswahl { get; set; }

    public byte NRepricingAktiv { get; set; }

    public byte NGeaendert { get; set; }

    public byte NDeaktiviertDurchBestand { get; set; }

    public DateTime? DZuletztGesendet { get; set; }

    public int? KVorlage { get; set; }

    public int KUser { get; set; }

    public virtual TAmazonStrategieAuswahl KAmazonStrategieAuswahlNavigation { get; set; } = null!;

    public virtual PfUser KUserNavigation { get; set; } = null!;

    public virtual TVorlage1? KVorlageNavigation { get; set; }
}
