using System;

namespace For
{
    class For
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + "月");
            }

            // 実行結果確認のための処理 ここから
            Console.WriteLine();
            Console.WriteLine("何かキーを押してください");
            Console.ReadKey();
            // ここまで
        }   
    }   
}
