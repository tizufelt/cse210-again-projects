public static class Animations{

public static void frame1(){
    Console.WriteLine("On Your Marks... ");
    Console.WriteLine(".......");
    Console.WriteLine(".*****.");
    Console.WriteLine(" .***. ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .   . ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public static void frame2(){
    Console.WriteLine("Get Ready...");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .***. ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .***. ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public static void frame3(){
    Console.WriteLine("Get Set...");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .   . ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .***. ");
    Console.WriteLine(".*****.");
    Console.WriteLine(".......");
   
}

public static void frame4(){
    Console.WriteLine(" AND GO!!! ");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .   . ");
    Console.WriteLine("  . . ");
    Console.WriteLine(" .   . ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public static void RunAnimation(){
    for(int i = 0; i <=1; i++){
            frame1();
            Thread.Sleep(1000);
            Console.Clear();

            frame2();
            Thread.Sleep(1000);
            Console.Clear();

            frame3();
            Thread.Sleep(1000);
            Console.Clear();

            frame4();
            Thread.Sleep(1000);
            Console.Clear();
       }

  } 

  public static void DisplaySpiner(int seconds){
    int i = 0;

    while( i <= seconds ){
            Console.Write("|");
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
            Console.Write("—");
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            i += 1;
            Console.Write("\b");

    }
   Console.Write(" ");
   Console.Write("\b");
  }
}