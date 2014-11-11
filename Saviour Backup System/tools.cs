using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saviour_Backup_System
{
    class tools
    {
        public static string Trim(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                return value.Substring(0, maxLength - 3) + "...";
            }
            return value;
        }
    }
}
