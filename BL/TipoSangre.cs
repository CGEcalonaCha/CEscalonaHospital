using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public  class TipoSangre
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CEscalonaHospitalEntities context = new DL.CEscalonaHospitalEntities())
                {
                    var query = context.TipoSangreGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.TipoSangre sangre = new ML.TipoSangre();
                            sangre.IdTipoSangre = obj.IdTipoSangre;
                            sangre.NombreSangre = obj.NombreSangre;

                            result.Objects.Add(sangre);
                        }

                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {

                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
