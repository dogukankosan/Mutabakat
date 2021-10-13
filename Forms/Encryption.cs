using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETARaporlama.Forms
{
  public  class Encryption
    {
        public string Enc(string gettext)
        {
            char[] dizi = gettext.ToCharArray();
            string returndo = string.Empty;
            foreach (char item in dizi)
            {
                returndo +=Convert.ToChar(item + 40);
            }
            return returndo;
        }
        public string Desc(string gettext)
        {
            char[] dizi = gettext.ToCharArray();
            string returndo = string.Empty;
            foreach (char item in dizi)
            {
                returndo += Convert.ToChar(item - 40);
            }
            return returndo;
        }

    }
}
