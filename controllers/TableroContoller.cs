using S.S.S.models;

namespace S.S.S.controllers
{
    public class TableroController
    {
        TableroModel modelo = new TableroModel();

        public int MostrarTotalProductos()
        {
            return modelo.ObtenerTotalProductos();
        }

        public decimal MostrarTotalVentas()
        {
            return modelo.ObtenerTotalVentas();
        }
    }
}