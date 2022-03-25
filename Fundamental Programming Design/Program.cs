// See https://aka.ms/new-console-template for more information

string? food;

Random random = new Random();
int i = random.Next(0,3);




Console.WriteLine("你要吃甚麼，有拉麵、齣齣、豆花");



switch(i)
{

     case 0:

        food = "拉麵";
        break;
 
     case 1:

        food = "齣齣";
        break;

     case 2:

        food = "我的豆花!!!";
        break;


}


food = Console.ReadLine();
Console.WriteLine(food);

switch(food)
{

     case "拉麵":

        Console.WriteLine("200元");
        break;
 
     case "齣齣":

        Console.WriteLine("100元");
        break;

     case "我的豆花!!!":

        Console.WriteLine("30塊!!!");
        break;


}

