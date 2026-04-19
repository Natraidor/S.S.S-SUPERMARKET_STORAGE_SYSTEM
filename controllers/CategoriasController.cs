using S.S.S.models;
using System.Data;

namespace S.S.S.controllers
{
    public class CategoriaController
    {
        CategoriasModel modelo = new CategoriasModel();

        // 🔍 Mostrar datos
        public DataTable MostrarCategorias()
        {
            return modelo.ObtenerCategorias();
        }

        // ➕ Agregar
        public void AgregarCategoria(string nombre, string descripcion)
        {
            modelo.InsertarCategoria(nombre, descripcion);
        }

        // ✏️ Editar
        public void EditarCategoria(int id, string nombre, string descripcion)
        {
            modelo.ActualizarCategoria(id, nombre, descripcion);
        }

        // ❌ Eliminar
        public void EliminarCategoria(int id)
        {
            modelo.EliminarCategoria(id);
        }
    }
}