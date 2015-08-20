using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFunctions
{
    public class CoolFunctions
    {
        public static int iterfactorial(int n)
        {
            int answer = 1;
            for (var i = n; i >= 1; i--)
            {
                answer *= i;
            }
            return answer;
        }

        public static int recurfactorial(int n)
        {
            if (n != 1)
            {
                return n * recurfactorial(n - 1);
            }
            else
            {
                // This is the base case
                return n;
            }
        }

        public int[] swapInPlace(int[] inputs, int left_most_index, int right_most_index)
        {
            return null;
        }

        public bool isSorted(int[] inputs)
        {
            throw new NotImplementedException();
        }
        public static int[] InsertionSort(int[] inputs)
        {
            var answer = new int[inputs.Length];
            var temp = new int[inputs.Length];
            // Get a forreal clone of this array.
            int[] copy_of_inputs = inputs.Clone() as int[];
            var i = 0;
            var j = i + 1;
            var swapped = false;
            while (i < copy_of_inputs.Length - 1 && swapped == false)
            {
                while (j < copy_of_inputs.Length) //
                {
                    var item = copy_of_inputs[i];
                    var second_item = copy_of_inputs[j];
                    if (item > second_item){
                        // Let's swap. Seems useful...
                        var tmpa = item;
                        var tmpb = second_item;
                        copy_of_inputs[i] = tmpb; // The item located at 'j'
                        copy_of_inputs[j] = tmpa;
                        //j++; // Keep an eye on this
                        swapped = true;
                    }
                    if (j == copy_of_inputs.Length - 1)
                    {
                        i = 0;
                        j = i + 1;
                        break;
                    } else
                    {
                        i++; //keep an eye on this
                        j = i + 1;// The same as j++;
                    }
                }
            }
            return copy_of_inputs; //
        }
    }
}

