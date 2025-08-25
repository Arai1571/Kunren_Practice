string x;
x = "今日は22日です。";



Console.WriteLine(x + "こんにちは！");


int a = 40;　//体重 
float b = 1.48f;//身長

// BMI指数
float bmi = a / (b * b);

Console.WriteLine("私のBMI指数は" + bmi + "です");

//算術演算子
int count = 10;
//countに５を足した数に置き換え
//count = count + 5;

//省略系 +を先に！
count += 5;


//インクリメント演算子
//count += 1;  //１だけ足す
//省略形
count++;


//デクリメント演算子
//count=count-1;
//count -= 1;
//省略形
count--;