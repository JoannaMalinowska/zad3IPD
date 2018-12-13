using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class perceptron
    {
        
        int iteration;
        int setNumber;
        double sigma; //funkcja aktywacji??

        class zestaw
        {
            int[] input { get; set; }
            int[] output { get; set; }
            public zestaw(int[] input, int[] output)
            {
                this.output = output;
                this.input = input;
            }
        }
        public void init()
        {
            //wejscia i wyjscia są w zadaniu identyczne

            zestaw zestaw1 = new zestaw(new int[] { 1, 0, 0, 0 }, new int[] { 1, 0, 0, 0 });
            zestaw zestaw2 = new zestaw(new int[] { 0, 1, 0, 0 }, new int[] { 0, 1, 0, 0 });
            zestaw zestaw3 = new zestaw(new int[] { 0, 0, 1, 0 }, new int[] { 0, 0, 1, 0 });
            zestaw zestaw4 = new zestaw(new int[] { 0, 0, 0, 1 }, new int[] { 0, 0, 0, 1 });






        }
    }
}
