using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Paciente
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CEscalonaHospitalEntities context = new DL.CEscalonaHospitalEntities())
                {
                    var query = context.PacienteGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Paciente paciente = new ML.Paciente();
                            paciente.IdPaciente = obj.IdPaciente;
                            paciente.Nombre = obj.Nombre;
                            paciente.ApellidoPaterno = obj.ApellidoPaterno;
                            paciente.ApellidoMaterno = obj.ApellidoMaterno;
                            paciente.FechaNacimiento = obj.FechaNacimiento.Value;
                            paciente.FechaIngreso = obj.FechaNacimiento.Value;
                            paciente.TipoSangre = new ML.TipoSangre();
                            paciente.TipoSangre.IdTipoSangre = obj.IdTipoSangre.Value;
                            paciente.TipoSangre.NombreSangre = obj.NombreSangre;
                            paciente.Sexo = obj.Sexo;
                            paciente.Sintomas = obj.Sintomas;

                            result.Objects.Add(paciente);
                        }

                        result.Correct = true;
                    }
                }
            }
            catch(Exception ex)
            {
              
                result.ErrorMessage= ex.Message;
            }
            return result;
        }
    }
}
