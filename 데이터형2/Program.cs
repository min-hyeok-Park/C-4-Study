using System;

namespace 데이터형2
{
    /*
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
    }
    public struct MyStruct2
    {
        public int Age;
        public MyStruct2(int InAge)
        {
            Age = InAge;
        }
    }
    */
    public struct MyStruct
    {
        public int Kor, Eng, Math, Total;
        public float Average;

        public void Compute()
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // 표준 입력 ( ConsoleKeyInfo(구조체), ReadKey(), ReadKey(bool intercept) (오버로딩) )
            // true : 화면 출력 안 함, false : 화면 출력
            /*
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                // KeyInfo = Console.ReadKey(true); <- 화면 출력 안됨.
                // 위에 코드 사용 후 if로 KeyInfo.KeyChar == 'a' 하면
                // a눌릴 때 마다 a가 누렸다 출력함. (대소문자 구별함)
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine("a가 눌렸다"); // 대소문자 구별하는지 확인용, 결과 : 구별 안함
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
            */
            /*
            Console.WriteLine("\n----------------------\n");

            // 사용자 지정형 (struct, enum, class, interface)
            // public(접근지정자) struct 구조체명 {멤버, 속성, 메서드}
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            MyStruct2 Test1;
            Test1.Age = 12;
            Console.WriteLine(Test1.Age);

            MyStruct2 Test2 = new MyStruct2();
            Console.WriteLine(Test2.Age);
            // 기본 생성자는 0으로 셋업

            MyStruct2 Test3 = new MyStruct2(12);
            Console.WriteLine("{0}", Test3.Age);

            Console.WriteLine(Test2.Age);
            Test2 = Test1;
            Console.WriteLine(Test2.Age);
            */

            // 국,영,수 점수 구조체 멤버 변수로 입력하고 메서드 호출하면 계산되도록
            MyStruct Test1 = new MyStruct();
            Test1.Kor = 80;
            Test1.Eng = 90;
            Test1.Math = 88;
            Test1.Compute();
            Console.WriteLine("총점 : {0} 평균 : {1}", Test1.Total, Test1.Average);
        }
    }
}
