using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment01
{
    public class Calculator
    {
        public int fNum { get; set; }
        public int sNum {  get; set; }
        public int Add()
        {
            return fNum+sNum;
        }
        public int Multi() 
        { 
            return fNum*sNum;
        }
        public int Sub()
        {
            return fNum-sNum;
        }
        public int Div() 
        {
            return fNum/sNum;
        }
    }
}
