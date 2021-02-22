using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public  class CategoriasBL
    {
            Contexto _contexto;

            public List<Producto> listadeCategorias { get; set; }

            public CategoriasBL()
            {
                _contexto = new Contexto();
                listadeCategorias = new List<Categoria>();
            }


            public List<Categoria> ObtenerCategoria()
            {
                listadeCategorias = _contexto.Categorias.ToList();
                return listadeCategorias;
            }


            public void GuardarCategoria(Categoria categoria)
            {
                if (categoria.Id == 0)
                {
                    _contexto.Categorias.Add(categoria);
                }
                else
                {
                    var CategoriaExistente = _contexto.Productos.Find(categoria.Id);
                    CategoriaExistente.Descripcion = categoria.Descripcion;
                }

                _contexto.SaveChanges();
            }


            public Producto ObtenerCategoria(int id)
            {
                var categoria = _contexto.Categorias.Find(id);
                return categoria;
            }

            public void EliminarCategoria(int id)
            {
                var categoria = _contexto.Categorias.Find(id);
                _contexto.Categorias.Remove(categoria);
                _contexto.SaveChanges();
            }
        }
}
