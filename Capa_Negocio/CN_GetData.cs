using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_GetData
    {
        private CD_GetData objectCD = new CD_GetData();
        public DataTable CN_ShowData(string sql_text) => objectCD.GetData(sql_text);

        public string ObtenerFechaActual() => DateTime.Today.ToString("D");
    }
}
