using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Personelailebilgi
{
    public long Id { get; set; }

    public string? Tckn { get; set; }

    public string? Isim { get; set; }

    public string? Tel { get; set; }

    public string? Egitimokul { get; set; }

    public string? Calismayer { get; set; }

    public string? Engel { get; set; }

    public long? Chid { get; set; }

    public string? Egitimokulbolum { get; set; }

    public string? Yakinlik { get; set; }

    public string? Egitimdurum { get; set; }

    public string? Calismadurum { get; set; }

    public string? Engellidurum { get; set; }

    public string? Okuldurum { get; set; }
}
