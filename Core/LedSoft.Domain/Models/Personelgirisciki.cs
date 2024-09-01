using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Personelgirisciki
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public bool? Giris { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }
}
