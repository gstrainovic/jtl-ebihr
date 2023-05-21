using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUserSession
{
    public int KUserSession { get; set; }

    public int? KOwnerUserSession { get; set; }

    public Guid IUserSessionId { get; set; }

    public int? KBenutzer { get; set; }

    public int? KMandant { get; set; }

    public Guid IApplicationId { get; set; }

    public string? CCustomIdentifier { get; set; }

    public string CHostname { get; set; } = null!;

    public int NProcessId { get; set; }

    public DateTimeOffset DLoggedIn { get; set; }

    public DateTimeOffset DLastHeartbeat { get; set; }

    public bool NIsSessionInterruptible { get; set; }

    public bool NSessionInterruptRequested { get; set; }

    public DateTimeOffset? DSessionInterruptRequestTimestamp { get; set; }

    public string? CSessionInterruptHostname { get; set; }

    public int? KSessionInterruptBenutzer { get; set; }

    public Guid? ISessionInterruptMessage { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TUserSession> InverseKOwnerUserSessionNavigation { get; set; } = new List<TUserSession>();

    public virtual TUserSession? KOwnerUserSessionNavigation { get; set; }
}
