using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.IRepositories
{
    //Debe heredar de IDisposable para que el Garbage Collector
    //pueda liberar memoria que ya no utilice.
    public interface IUnityOfWork : IDisposable
    {
        //Cada una de las propiedades deben ser de solo lectura 
        IServicioAtencionRepository Atenciones { get; }
        ICategoriaProductoRepository CategoriasProducto { get; }
        IClienteRepository Clientes { get; }
        IMascotaRepository Mascotas { get; }
        IProductoRepository Productos { get; }
        IVentaRepository Ventas { get; }
        IVeterinarioRepository Veterinarios { get; }

        //Metodo que guardara los cambios en la base de datos.

        int SaveChanges();
        void StateModified(object entity);
    }
}
