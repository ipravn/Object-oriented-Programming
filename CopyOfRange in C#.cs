static int[] copyOfRange (int[] src, int start, int end) {
            int len = end - start;
            int[] dest = new int[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }


////////////////////////////////////////////////////////////////////////////////////////////////

/*internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 78, 9, 14, 51, 7, 99, 11, 47, 87 };
            int mid = arr.Length / 2;
            
            int[] left = copyOfRange(arr, 0, mid);
            int[] right = copyOfRange(arr, mid, arr.Length);
            
            Console.WriteLine(String.Join( ",",left));
            Console.WriteLine(String.Join( ",",right));
            
        }
        
        
        static int[] copyOfRange (int[] src, int start, int end) {
            int len = end - start;
            int[] dest = new int[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }

       
        
    }*/
            
 //Output:
 //78,9,14,51
 //7,99,11,47,87
