using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PersonelBanka
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public string? Bankaisim { get; set; }

    public string? Subeisim { get; set; }

    public string? Iban { get; set; }

    public string? Hesapno { get; set; }

    public string? Aciklama { get; set; }
}
