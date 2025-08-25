//シンプルなif文

string money; //所持金
Console.Write("所持金はいくらありますか？：");
money = Console.ReadLine(); //ユーザーの入力待ち

Console.WriteLine("所持金は" + money + "円ですね");

// if文
// 型変換　文字列→整数へ
int x;
x = int.Parse(money);

// xが1000以上なら
if (x >= 1000)
{
    Console.WriteLine("まぐろ丼にします");
}

else if (x >= 500)
{
    Console.WriteLine("からあげ弁当にします");
}

else
{
    Console.WriteLine("そぼろ丼にします");
}


// switch文
switch (x) //xが調査対象
{
    case >= 1000:　//xの中身が1000以上なら
        Console.WriteLine("まぐろ丼にします");
        break;//switch文を抜ける

    case >= 500:
        Console.WriteLine("からあげ弁当にします");
        break;

    default:
        Console.WriteLine("そぼろ丼にします");
        break;
}

dotnet run
