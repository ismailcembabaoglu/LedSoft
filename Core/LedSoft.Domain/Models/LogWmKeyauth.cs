using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogWmKeyauth
{
    public long Id { get; set; }

    public long? Mobileuserid { get; set; }

    public DateTime? Datetime { get; set; }

    public DateTime? Expiredatetime { get; set; }

    public string? Keyauthcode { get; set; }

    public long? Clu1id { get; set; }

    public long? Clu2id { get; set; }

    public long? Clu3id { get; set; }

    public long? Userid { get; set; }

    public string? Definition { get; set; }

    public string? Clu1caption { get; set; }

    public string? Clu2caption { get; set; }

    public string? Clu3caption { get; set; }

    public bool? Smsgonderildi { get; set; }
}
