//
//Test.cs
//Created by Valerij Dimitriev
//
//on 2021.09.13
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection3
{
    class Test
    {
        int field1;
        int field2;
        public Test(int field1, int field2) {
            this.field1 = field1;
            this.field2 = field2;
        }
        public override string ToString()
        {
            return $"field1 = {field1} field2 = {field2} Field3 = {Field3}";
        }
        public void setField1(int field1) {
            this.field1 = field1;
        }
        public int getField1() {
            return field1;
        }


        public int Field2 {             //Cвойство
            set { field2 = value; }
            get { return field2; }
        }

        public int Field3 { set; get; }//автосвойство

        
    }
}
