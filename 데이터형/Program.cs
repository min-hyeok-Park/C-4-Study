using System;

namespace 데이터형
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f;
            float value2 = 10.12f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f2} {2}", value1, value2, sum);
            // 소수점 자리 표시 = {1:f1} 첫째 자리, f2둘째 자리

            Console.WriteLine("\n----------------------\n");

            // null값 허용 (int?, float? 등 "?")
            int? Num1 = null;
            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("null 값");
            Console.WriteLine("null : {0}", Num1);
            // int? ?는 null 값을 허용해주는 애
            // HasValue 값이 있는 지 없는지

            Console.WriteLine("\n----------------------\n");

            // 형변환 (Parse, Convert.ToInt32, ToString)
            int value3 = 127;
            string str1 = value3.ToString();
            Console.WriteLine(str1);

            int value4 = Convert.ToInt32(str1);
            Console.WriteLine(value4);

            string str2 = "3.14";
            float value5 = float.Parse(str2);
            Console.WriteLine(value5);
            // Convert, ToInt32를 쓸 수 있다는 것은 static 정적이 작용했다는 것.

            Console.WriteLine("\n----------------------\n");

            // 박싱과 언박싱 (많이 쓰이지는 않는듯.)
            int i = 123;
            object obj = i; // 박싱
            Console.WriteLine("{0}", (int)obj); // 언박싱

            // 힙메모리에 있는 것을 공유하는지 복사하는지 확인용
            int j = 123;
            object o = j;
            j = 456;
            Console.WriteLine("{0} {1}", j, (int)o);
            // 공유 X, 복사 O 별도의 메모리로 사용

            Console.WriteLine("\n----------------------\n");

        }
    }
}
