public class Program
{
    static void Bai1(int[] arr){
        HashSet<int> set = new HashSet<int>();  
        foreach (var item in arr)
        {
            if(set.Contains(item)){
                Console.WriteLine("true");
                return;
            }else{
                set.Add(item);
            }
        }
        Console.WriteLine("false");
    }
    static void Bai2(string S){
        int left = 0;
        int right = S.Length - 1;
        int changes = 0;
        while(left < right){
            if(S[left] != S[right]){
                changes++;
            }
            left++;
            right--;
        }
        Console.WriteLine(changes);
    }
    static void Bai3(){
        string[] input1 = Console.ReadLine().Split();
        int N = int.Parse(input1[0]);
        int X = int.Parse(input1[1]);
        int position = 0;
        int jumps = 0;
        string[] input2 = Console.ReadLine().Split();
        int[]L = new int[N - 1];
        for(int i = 0; i < N - 1; i++){
            L[i] = int.Parse(input2[i]);    
        }
        for(int i = 0; i < N; i++){
            position += L[i];
            jumps++;
            if(position >= X){
                Console.WriteLine(jumps);
                return;
            }       
        }
        Console.WriteLine(jumps);
    }
    static void Main(string[] args)
    {
        int [] A = {1, 1, 2, 3, 4, 5};
        Bai1(A);
        string S = "abcdecabc";
        Bai2(S);
        Bai3();
    }
}

