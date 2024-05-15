using System;
using System.Collections.Generic;

namespace RebecaBarrezueta_APIBurger.Data.Models;

public partial class Burguer
{
    public int BurguerId { get; set; }

    public string Name { get; set; } = null!;

    public bool WithCheese { get; set; }

    public decimal Precio { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
