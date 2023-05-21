using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVorlage1
{
    public int KVorlage { get; set; }

    public string CName { get; set; } = null!;

    public int KAmazonStrategieAuswahl { get; set; }

    public virtual TAmazonStrategieAuswahl KAmazonStrategieAuswahlNavigation { get; set; } = null!;

    public virtual ICollection<TAmazonTask> TAmazonTasks { get; set; } = new List<TAmazonTask>();
}
