namespace Capa_Entidad;
public class PersonaCLS
{
    public int idpersona { get; set; }
    public string nombrecompleto { get; set; } = "";
    public string correo { get; set; } = "";
    public string fechanacimientocadena { get; set; } = "";

    //Defino campos de tabla
    public string nombre { get; set; } = "";
    public string appaterno { get; set; } = "";
    public string apmaterno { get; set; } = "";
    public DateTime fechanacimiento { get; set; }
    public int idsexo { get; set; }

    public string nombrearchivo { get; set; } = "";
    public string fotocadena { get; set; } = "";
    public byte[] archivo { get; set; }
}

