using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio3_1040121
{
    internal class Scanner
    {
        private const string PlacasPattern = @"^(P|O|M|A|C)[0-9]{3}[A-Z]{3}$";
        private const string FechasPattern = @"^[0-9]{4}[-/](0[1-9]|1[0-2])[-/](0[1-9]|[12][0-9]|3[01])\s+([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
        private const string SetsPattern = @"^(\s*SETS\s*(([A-Z])+\s*[=]\s*((('([a-zA-Z_]+)')+([.][.]|[\+])?)|(('([a-zA-Z_0-9]+)')+([.][.]|[\+])?)|((CHR[(]([0-9]+)[)])+([.][.])?))+\s*)+\s*)?$";

        public static bool ScannerPlacas(string placa)
        {
            return Regex.IsMatch(placa, PlacasPattern);
        }

        public static bool ScannerFechas(string fecha)
        {
            return Regex.IsMatch(fecha, FechasPattern);
        }

        public static bool ScannerSets(string SETS)
        {
            return Regex.IsMatch(SETS, SetsPattern);
        }
    }
}
