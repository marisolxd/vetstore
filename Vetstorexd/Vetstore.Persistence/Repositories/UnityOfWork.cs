using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly VetstoreDbContext _Context;
        //private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IServicioAtencionRepository Atenciones { get; private set; }
        public ICategoriaProductoRepository CategoriasProducto { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IMascotaRepository Mascotas { get; private set; }
        public IProductoRepository Productos { get; private set; }
        public IVentaRepository Ventas { get; private set; }
        public IVeterinarioRepository Veterinarios { get; private set; }

        public UnityOfWork()
        {

        }

        private UnityOfWork(VetstoreDbContext context)
        {
            //Se crea un icono contexto de base de datos
            //para apuntar todos los repositorios a la misma base de datos 
            _Context = context;

            Atenciones = new ServicioAtencionRepository(_Context);
            CategoriasProducto = new CategoriaProductoRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Mascotas = new MascotaRepository(_Context);
            Productos = new ProductoRepository(_Context);
            Ventas = new VentaRepository(_Context);
            Veterinarios = new VeterinarioRepository(_Context);

        }

        //Implementacion del patron singleton para instanciar la clase InityOfWork
        //Con este patron se asegura que en cualquier parte de codigo que se quiera 
        //instancia la base de datos, se devuelva una unica referencia.
        //public static UnityOfWork Instance
        //{
        //    get
        //    {
        //        //Variable de control para manejar el acceso concurrente 
        //        //al instanciamiento de la clase  UnityOfWork
        //        lock (_Lock)
        //        {
        //            if (_Instance == null)
        //                _Instance = new UnityOfWork();
        //        }

        //        return _Instance;
        //    }
        //}

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
