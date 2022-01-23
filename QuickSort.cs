using System;


namespace csarp_kokletturmece
{


    class Program
    {


        static void quickSort(int[] arr,int p,int r)
        {

            int pivot = 0;

            
            if (p < r)
            {
                
                pivot=siralaBaba(arr, p, r);
                quickSort(arr, p, pivot - 1);
                quickSort(arr, pivot + 1, r);
            }
             
        }

        static int siralaBaba(int[] arr,int p,int r)
        {
            int pivot = r;
            int i = p - 1;

            for(int j = p; j < pivot; j++)
            {
                if (arr[j] < arr[pivot])
                {
                    i++;
                    int temp = 0;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }

            int tmp = 0;
            tmp = arr[i+1];
            arr[i+1] = arr[pivot];
            arr[pivot] = tmp;
            pivot = i+1;

            return pivot;


        }
     
        static void Main(string[] args)
        {
            int[] arr = { 6,2,3,4,7,234,756,346,5442,3,5437,56,25423,5,427,653,7625,432,6354,7,4,3,7,9,3,2,1,7,325,437,3245 };

            quickSort(arr, 0, arr.Length-1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            
        }
    }
}