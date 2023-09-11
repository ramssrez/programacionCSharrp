using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDPRN3RRP2302B1
{
    public class SentenciaSQLAndStrings
    {
        public const string SQL_OBTENER_PACIENTES_RRP = "SELECT idPacientes as Id, Nombre, ApellidoPaterno as 'Apellido Paterno', ApellidoMaterno as 'Apellido Materno', Direccion, Celular, TelefonoFijo as 'Telefono Fijo', Email, Edad, Sexo, Tipo as 'Estado Civil' FROM tbpacientesrrp INNER JOIN  tbestadocivilrrp ON tbpacientesrrp.idEstadoCivil = tbestadocivilrrp.idEstadoCivil ORDER By idPacientes ASC";
        public const string SQL_OBTENER_PACIENTES_FILTRO_RRP = "SELECT idPacientes as Id, Nombre, ApellidoPaterno as 'Apellido Paterno', ApellidoMaterno as 'Apellido Materno', Direccion, Celular, TelefonoFijo as 'Telefono Fijo', Email, Edad, Sexo, Tipo as 'Estado Civil' FROM tbpacientesrrp INNER JOIN  tbestadocivilrrp ON tbpacientesrrp.idEstadoCivil = tbestadocivilrrp.idEstadoCivil";
        public const string SQL_OBTENER_MEDICO_RRP = "SELECT tbmedicosrrp.idMedicos as Id, tbmedicosrrp.Nombre as Nombre, tbmedicosrrp.ApellidoPaterno as 'Apellido Paterno',tbmedicosrrp.ApellidoMaterno as 'Apellido Materno', tbmedicosrrp.Cedula,tbespecialidadesrrp.Nombre as Especialidad FROM tbmedicosrrp inner join tbespecialidadesrrp on tbmedicosrrp.idEspecialidades = tbespecialidadesrrp.idEspecialidades ORDER By idMedicos ASC";
        public const string SQL_OBTENER_MEDICO_FILTTRO_RRP = "SELECT tbmedicosrrp.idMedicos as Id, tbmedicosrrp.Nombre as Nombre, tbmedicosrrp.ApellidoPaterno as 'Apellido Paterno',tbmedicosrrp.ApellidoMaterno as 'Apellido Materno', tbmedicosrrp.Cedula,tbespecialidadesrrp.Nombre as Especialidad FROM tbmedicosrrp inner join tbespecialidadesrrp on tbmedicosrrp.idEspecialidades = tbespecialidadesrrp.idEspecialidades";
        public const string SQL_OBTENER_ESPECIALIDADES_RRP = "SELECT idEspecialidades, Nombre, Descripcion FROM tbespecialidadesrrp";
        public const string PatronDireccionRRP = @"^[0-9A-Za-z#,\s]+$";
        public const string PatronEspecialidaRRP = @"^[\p{L}\p{M},\d\s]+|ñ$";
        public const string PatronDatosRRP = @"^[\p{L}\p{M}]+$";
        public const string PatronEmailRRP = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        
        public const string INGRESO_NOMBRE = "Ingrese el nombre";
        public const string INGRESO_APELLIDO_PATERNO = "Ingrese el apellido paterno";
        public const string INGRESO_APELLIDO_MATERNO = "Ingrese el apellido materno";
        public const string INGRESO_TELEFONO_FIJO = "Ingrese el telefono fijo";
        public const string INGRESO_CELULAR = "Ingrese el telefono celular";
        public const string INGRESO_EMAIL = "Ingrese el email";
        public const string INGRESO_DIRECCION= "Ingrese la dirección";
        public const string INGRESO_EDAD = "Ingrese una edad correcta";
        public const string INGRESO_ESTADO_CIVIL ="Seleccione el estado civil";

        public const string INGRESO_EMAIL_FORMATO_CORRECTO = "Ingrese el correo en formato correcto";
        public const string NO_CARACTERES_ESPECIALES = "No se permiten caracteres especiales";
        public const string NO_SIZE_PHONE = "El número de telefono debe de tener 10 caracteres";
        //public const string NO_DATOS;
        //Método que concatena el rango de los caracteres
        public static string RangoOpciones(int v1, int v2)
        {
            return string.Format("El texto debe ser entre {0} y {1} caracteres", v1, v2);
        }
    }
}
