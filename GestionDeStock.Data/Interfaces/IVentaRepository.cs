using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface IVentaRepository 
    {
        Venta GetById(int id);
        IEnumerable<Venta> GetAllVentas();
        void Add(Venta venta);
    }
}
