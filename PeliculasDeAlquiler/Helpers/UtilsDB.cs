using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasDeAlquiler.Helpers
{
    public class UtilsDB
    {
        public static string GetFecha(DateTime f)
        {
            return f != DateTime.MinValue ? f.ToString("yyyy-MM-dd") : null;
        }

        public static int GetBit(bool valor)
        {
            return valor ? 1 : 0;
        }
    }
}
