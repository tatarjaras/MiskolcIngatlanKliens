using System;
using System.Collections.Generic;

namespace MiskolcIngatlanKliens.Models;

public partial class Ingatlan
{
    public int Id { get; set; }

    public int Telepules { get; set; }

    public int Cim { get; set; }

    public int Ar { get; set; }

    public int Tipus { get; set; }

    public int KepNev { get; set; }

    public int Ugyintezoid { get; set; }

    public virtual Ugyintezo Ugyintezo { get; set; } = null!;
}
