using System;

class MainClass {
  public static void Main (string[] args) {
    double sum =0;
    while(true){
Console.WriteLine ("Enter Hight:\nexit Enter 0 :");
double Hight = Convert.ToDouble(Console.ReadLine());
if (Hight == 0){
  break;
}
sum +=Hight;
    }
Console.WriteLine ("sum :" + sum);
    
  }
}