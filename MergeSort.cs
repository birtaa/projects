using System;


namespace csarp_kokletturmece
{


    class Program
    {
        public static int[] parcalababa(int[] array)
        {

            

            if (array.Length <= 1)
                return array;

            int[] left;
            int[] right;
            int[] sonuc = new int[array.Length];
            int mid;
            mid = array.Length / 2;

            left = new int[mid];
            if (array.Length % 2 == 0)
                right = new int[mid];
            else
                right = new int[mid + 1];

            for (int i = 0; i < mid; i++)
                left[i] = array[i];
            int j = 0;
            for (int i = mid; i < array.Length; i++)
            {
                right[j] = array[i];
                j++;
            }


            left = parcalababa(left);
            right = parcalababa(right);
            sonuc = birlestirbaba(left, right);
            return sonuc;
        }

        public static int[] birlestirbaba(int[] left, int[] right)
        {
            int[] birlesikArray = new int[left.Length + right.Length];
            int indexLeft = 0;
            int indexRight = 0;
            int indexBirlesik = 0;

            for (int i = 0; i < birlesikArray.Length; i++)
            {

                if(indexLeft<left.Length && indexRight < right.Length)//SOL SAG VAR MI 
                {
                    if (left[indexLeft] < right[indexRight])
                    {
                        birlesikArray[indexBirlesik] = left[indexLeft];
                        indexLeft++;
                        indexBirlesik++;
                    }
                    else
                    {
                        birlesikArray[indexBirlesik] = right[indexRight];
                        indexRight++;
                        indexBirlesik++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    birlesikArray[indexBirlesik] = left[indexLeft];
                    indexLeft++;
                    indexBirlesik++;
                }
                else
                {
                    birlesikArray[indexBirlesik] = right[indexRight];
                    indexRight++;
                    indexBirlesik++;
                }

            }

            return birlesikArray;





        }
        static void Main(string[] args)
        {

            int[] abi = { 5, 1, 13, 4, 9, 4, 62, 354, 46, 55,65,436,547,537,34,54,23231,4,3465,5,87,659,5,63423,4,21,4324,6,6538,6749,38, 3 };

            int[] abla = parcalababa(abi);

            foreach (var item in abla)
            {
                Console.WriteLine(item);
            }

                
                
        }
    }
}