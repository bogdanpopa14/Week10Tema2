using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOp
{
    public class ReversedString
    {
        string a;
        public ReversedString(string s)
        {
            this.a = s;
        }

        public string ReversedIgnore()
        {


           
           
            string s1=a;
            StringBuilder sb = new StringBuilder(s1);
            int j = 0;
            int i = a.Length - 1;
            while (j <= i)
            {
                if(!char.IsLetter(a[j]))
                { j++; }
                else if(!char.IsLetter(a[i]))
                { i--; }
                else
                {
                    char aux = a[j];
                    sb[j] = s1[i];
                    sb[i] = aux;
                    j++;
                    i--;
                }
            }

            return sb.ToString();
        }
    }
}
