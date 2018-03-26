# CsForStatement
for文（.NET Core）

## 処理
コンソールアプリとして1月から12月までを出力します。

## コード
```
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
```

## 出力結果  
```
1月
2月
3月
4月
5月
6月
7月
8月
9月
10月
11月
12月

何かキーを押してください
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
