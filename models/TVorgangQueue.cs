using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVorgangQueue
{
    public int KVorgangQueue { get; set; }

    public int KVorgang { get; set; }

    public int KQueue { get; set; }

    public virtual TQueue1 KQueueNavigation { get; set; } = null!;

    public virtual TVorgang KVorgangNavigation { get; set; } = null!;
}
