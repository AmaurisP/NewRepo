public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

public class Empleado : MiembroDeLaComunidad
{
    public string Puesto { get; set; }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public int AñoGraduacion { get; set; }
}

public class Docente : Empleado
{
    public string Materia { get; set; }
}

public class Administrativo : Empleado
{
    public string Departamento { get; set; }
}

public class Administrador : Docente
{
}

public class Maestro : Docente
{
}
