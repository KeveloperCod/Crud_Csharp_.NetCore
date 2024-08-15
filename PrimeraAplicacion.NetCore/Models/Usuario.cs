using System;
using System.Collections.Generic;

namespace PrimeraAplicacion.NetCore.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? Fehca { get; set; }

    public string? Clave { get; set; }
}
