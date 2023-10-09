namespace HomeWork
{
    internal class Task3
    {



        public void Push(ref int[] arr, int x)
        {
            int[] r = new int[arr.Length + 1];

            for(int i = 0; i < arr.Length; i++)
            {
                r[i] = arr[i];
            }
            r[arr.Length] = x;

            arr = r;
        }
    }
}
