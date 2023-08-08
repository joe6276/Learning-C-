using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitives_Datatypes
{
    public  class Capitalize
    {   
        public string Sentense { get; set; }
        public Capitalize(string sent) 
        {
            Sentense = sent;
        }

        public string CapitalizeSentense()
        {   
            List<string> words = new List<string>();
            foreach (var item in Sentense.Split(" "))
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }
                //var capitalizedWord= item[0].ToString().ToUpper() + item.Substring(1).ToLower();
                var other = "";
                for(int i = 1; i < item.Length; i++)
                {
                    other += item[i];   

                }
                words.Add(item[0].ToString().ToUpper()+other.ToLower());
            }

            return string.Join(" ", words);
        }
    }
}
