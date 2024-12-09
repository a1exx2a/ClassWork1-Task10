namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {-1,2,3,4,5,6,7,8,9,-10};
        
        for (int i = 0; i < x.Length; i++){
            if (x[i] < 0){
                x[i] = 0;
            }
        }

        foreach (int i in x){
            Console.WriteLine(i);
        }
    }
}
