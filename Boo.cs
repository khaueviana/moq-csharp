using System;

namespace UnitTesting
{
    public class Boo
    {        
        public int MyProperty { get; set; } 
        public int Sum(int a, int b) => a + b;

        public void Error()
        {
            throw new NotImplementedException();
        }
    }
}
