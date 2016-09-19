using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Parser
    {
        private int value;
        private string text;

        public Parser(string text)
        {
            //Por enquanto somente soma
            this.text = text;
            Sum_Sub();
        }

        public int getValue()
        {
            return value;
        }

        private void Sum_Sub()
        {
            /*Implementação Loka*/
            string[] numbersToSum = text.Split('+');
            value = 0;
            foreach (string s in numbersToSum)
            {
                value += Int32.Parse(s);
            }
        }
    }
}
