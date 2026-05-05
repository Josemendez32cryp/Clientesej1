namespace Clientesej1.Service

{
    using Clientesej1.Models;
    using System.Text.Json;

    public class VehiculosService
    {
        private readonly string _rutaArchivo = "vehiculos.json";

        public void Guardar(Vehiculo nuevoVehiculo)
        {
            List<Vehiculo> lista = new();
            if (File.Exists(_rutaArchivo))
            {
                var jsonExistente = File.ReadAllText(_rutaArchivo);
                lista = JsonSerializer.Deserialize<List<Vehiculo>>(jsonExistente) ?? new();
            }

            lista.Add(nuevoVehiculo);

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            var nuevoJson = JsonSerializer.Serialize(lista, opciones);
            File.WriteAllText(_rutaArchivo, nuevoJson);
        }

        public List<Vehiculo> Leer()
        {
            if (!File.Exists(_rutaArchivo))
                return new List<Vehiculo>();

            try
            {
                var json = File.ReadAllText(_rutaArchivo);
                return JsonSerializer.Deserialize<List<Vehiculo>>(json) ?? new List<Vehiculo>();
            }
            catch
            {
                return new List<Vehiculo>();
            }
        }
    }
}