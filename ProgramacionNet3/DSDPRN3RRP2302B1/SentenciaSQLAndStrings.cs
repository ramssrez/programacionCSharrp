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
        public const string PatronEspecialidaRRP = @"^[0-9A-Za-z,\s]+$";
        public const string PatronDatosRRP = @"^[\p{L}\p{M}]+$";
        public const string PatronEmailRRP = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
    }
}
