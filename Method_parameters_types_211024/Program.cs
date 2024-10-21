namespace Method_parameters_types_211024
{
    class temp
    {
        public void method7(string name="user1",string city="pune")
        {
            Console.WriteLine("user information");
            Console.WriteLine("Name ="+name);
            Console.WriteLine("city ="+city);
        }
        //without parameter array example
        public void method5(int a1,int a2,int a3,int a4)
        {
            int total = a1 + a2 + a3 + a4;
            Console.WriteLine("sum="+total);
        }
        //with parameter array example
        public void method6(params int[]a)       
        {
            int total=0;
            for (int i = 0; i < a.Length; i++)
            {
                total = total + a[i];
            }
            Console.WriteLine("sum=" + total);
        }
        public void method2(ref int n)//value type
        {
            Console.WriteLine("value of n in method2 =" + n);
            n = 999;
            Console.WriteLine("value of n after modification in method2 ="+n);
        }
        public void method1(ArithmeticOperations ao1)//reference type
        {
            Console.WriteLine("value of num in method1 =" + ao1.num);
            ao1.num = 999;
            Console.WriteLine("value of num after modification in method1 =" + ao1.num);
        }

        public void method3(out int n1)
        {
           
            n1 = 123;
            int x = n1;
            n1 = 777;
        }
        public void method4(in int n7)
        {
            Console.WriteLine("n7="+n7);//valid
            int ans = n7;//valid
            //n7 = 0;// invalid

        }
    }
    class ArithmeticOperations
    {
       public int num;
        public void sum(int x,int y)
        {
            int z = x + y;
            //Console.WriteLine("x = 100  and y = 200  and z= 300");
            Console.WriteLine($"x = {x} and y = {y} and z = {z}");
        }
        public void sum1(int x, int y,int z)
        {
            int result = x + y+z;
            //Console.WriteLine("x = 100  and y = 200  and z= 300");
            Console.WriteLine($"x = {x} and y = {y} and z = {z} Sum="+ result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations obj = new ArithmeticOperations();
            //obj.sum(y:100,x:200);//named parameters

            //obj.sum1(y:11, z:20, x:30);
            //obj.sum1(11,20, 30);//value parameters

            obj.num = 111;
            //Console.WriteLine("value of num in main method ="+obj.num);
            temp t1 = new temp();
            //t1.method1(obj);
            //Console.WriteLine("value of num in main method =" + obj.num);

            //Console.WriteLine("----------------------------------");
            //int x = 555;
            //Console.WriteLine("value of x in main method =" + x);
            //t1.method2(ref x);//calling place to method
            //Console.WriteLine("value of x in main method =" + x);

            int n5 = 100;
            //t1.method3(out n5);
            //Console.WriteLine("n5="+n5);

            Console.WriteLine(n5);
            t1.method4(in n5);
            Console.WriteLine(n5);

            //t1.method5(11,22,33,44);
            //t1.method6(1, 2, 3,7,9,8,45,3,98);
            //t1.method6(222);
            //t1.method6();

            //int[] ar = new int[] { 111, 222, 333 };
            //t1.method6(ar);

            t1.method7("rajesh", "Mumbai");
            t1.method7("anand");
            t1.method7();
            t1.method7(city:"delhi");
        }
    }
}
