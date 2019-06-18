using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    public class Utils
    {
      public  static bool isValidStringInput(string text)
        {
            if (text.Trim().Length < 0) return false;
            return true;
        }
    }
}
