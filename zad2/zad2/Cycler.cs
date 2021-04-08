using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Cycler
    {
        int i = Convert.ToInt32(File.ReadAllText("save.txt", Encoding.Default));

        public int method(int param)
        {

            return param + 1;
            
        }

       public int Output(List<int> numbers)
        {
            /* int result;
                 int i = 0;
                 if (i <= numbers.Count)
                 {
                     result = numbers[i];
                      i=i+1;
                 }
                 else
                 {
                     i = 0;
                     result = numbers[i];
                 }
                 return result; */

            /*int result;
            int i = 0;
            do
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
            while (i <= i++);
            {
                result = numbers[i];
                return result;
            }*/

            //i = Convert.ToInt32(File.ReadAllText("save.txt", Encoding.Default));
            int result;
            result = numbers[i];
            method(i);
            File.WriteAllText("save.txt", i.ToString());
            return result;
            
        }
    }
}
