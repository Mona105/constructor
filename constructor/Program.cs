using System;
namespace hello
{
    class MyApp
    {
        public string name;
        public int a;
        public MyApp(string name)
        {
            this.name = name;

        }
        public void get(int a)
        {
            this.a = a;
            Console.WriteLine(this.name);
            Console.WriteLine(this.a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyApp obj = new MyApp("Mona");
            obj.get(10);

        }
    }
}