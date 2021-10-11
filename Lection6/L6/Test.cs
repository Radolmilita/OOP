using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    sealed class Test
    {
        int result;
        string studentName;
        string[] arr;
        public Test(int result, string studentName) 
        {
            this.result = result;
            this.studentName = studentName;
        }
        public Test(int result) {
            this.result = result;
        }
        public static Test operator + (Test testM, Test testA) {
            return new Test(testM.result + testA.result);
        }

        public static Test operator ++(Test testInc) {
            Test ta = new Test(testInc.result);
            ta.result++;
            return ta;
        }
        public static int operator -(Test t1, int val)
        {
            return t1.result - val;
        }
        public static implicit operator Test(int result) {
            return new Test(result);
        }
        public static explicit operator Int32(Test a) {
            return a.result;
        }
        public static bool operator ==(Test arr, string value) {
            return arr.studentName == value;
        }
        public static bool operator !=(Test arr, string value) {
            return !(arr == value);
        }

        public override string ToString()
        {
            return $"результат теста  {result} Имя студента {studentName}";
        }
    }
}
