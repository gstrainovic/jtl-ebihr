using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPackage
{
    public int KPackage { get; set; }

    public int? KPackageServer { get; set; }

    public int KVersand { get; set; }

    public string CTrackingId { get; set; } = null!;

    public byte NServiceProvider { get; set; }

    public string CShipperCountryIso { get; set; } = null!;

    public string CReceiverCountryIso { get; set; } = null!;

    public string CReceiverZipCode { get; set; } = null!;

    public DateTime? DNextUpdateDate { get; set; }

    public DateTime? DRegisteredAt { get; set; }

    public byte NCurrentStateType { get; set; }

    public virtual TVersand KVersandNavigation { get; set; } = null!;

    public virtual ICollection<TMessage1> TMessage1s { get; set; } = new List<TMessage1>();

    public virtual ICollection<TPackageDpdProperty> TPackageDpdProperties { get; set; } = new List<TPackageDpdProperty>();

    public virtual ICollection<TState> TStates { get; set; } = new List<TState>();
}
