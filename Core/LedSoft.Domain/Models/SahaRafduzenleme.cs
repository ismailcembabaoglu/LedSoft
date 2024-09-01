using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SahaRafduzenleme
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Chid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Temsilciid { get; set; }

    public byte[]? FotografEski { get; set; }

    public byte[]? FotografYeni { get; set; }

    public string? Aciklama { get; set; }

    public Guid? Udid { get; set; }

    public long? Ziyaretid { get; set; }
}
