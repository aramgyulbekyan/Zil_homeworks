using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_class
{
    class StringToIntArray
    {
        private string field;
        public StringToIntArray (string field)
        {
            this.field = field;
        }

        public int[] ToIntArray(string field)
        {
            int[] result = new int[field.Length];
            for (int i = 0; i < field.Length; i++)
            {
                result[i] = int.Parse(field[i].ToString());
            }
            return result;
        }
        public int max (int[] input )
        {
            int max = (ToIntArray(field).Max(element => Math.Abs(element)));
            return max;
        }


    }
}
