﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Interfaces
{
    public interface IListar<TEntidad, TEntidadID>
    {
        List<TEntidad> Listar();
        TEntidad SeleccionarPorID(TEntidadID entidadID);
    }
}
