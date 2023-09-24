// 백준 20124 모르고리즘 회장님 추천 받습니다

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[] { };
            int value = 0;
            string name = string.Empty;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                if (Convert.ToInt32(input[1]) > value)
                {
                    name = input[0];
                    value = Convert.ToInt32(input[1]);
                }
                else if (Convert.ToInt32(input[1]) == value && string.Compare(input[0], name) < 0)
                {
                    name = input[0];
                }
            }

            Console.WriteLine(name);
        }
    }
}