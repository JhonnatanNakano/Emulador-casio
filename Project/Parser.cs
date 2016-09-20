using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Parser
    {
        private int value = 0;
        private string text;

        public Parser(string text)
        {
            //Por enquanto somente soma
            this.text = procura_negativo(text);
            Sum_Sub(this.text);
        }

        public int getValue()
        {
            return value;
        }

        private string procura_negativo(string text)
        {
            int i = text.IndexOf("(-)");
            char[] aux;
            while(i != -1)
            {
                aux = text.ToCharArray();
                aux[i+1] = '_';
                text = new string(aux);
                i = text.IndexOf("(-)");
            }
            return text;
        }

        private int soma_negativos(string text)
        {
            text = text.Replace("(_)", "-");
            string[] negativesNumbers = text.Split('-');
            int value_neg = 0;
            bool wasNegative = false;

            for (int i = 0; i < negativesNumbers.Length; i++)
            {
                if (!negativesNumbers[i].Equals(""))
                {
                    if (wasNegative)
                        value_neg += Int32.Parse(negativesNumbers[i]);
                    else
                        value_neg -= Int32.Parse(negativesNumbers[i]);
                    wasNegative = false;
                }
                else if (i != 0)
                    wasNegative ^= true;
            }

            return value_neg;
        }

        private int Sum_Sub(string text)
        {
            /*Implementação Loka*/
            string[] numbersToSum = text.Split('+');
            int value = 0;
            bool swap = false; //guarda o último sinal do sum anterior

            foreach (string sum in numbersToSum)
            {
                /*
                 * Aqui, cada string ainda pode ter uns subs entre eles então teremos que quebrar denovo
                 * Essa lógica é complicada... mas vamos lá:
                 * - (value_sub) guardará o valor final de sum. Ele será ele mesmo caso não tenha nenhum
                 * operador de subtração dentro dela. Caso contrário, sum será quebrado para calcular o 
                 * valor final incluíndo as subtrações
                 * - (numbersForSub) é a variável que separa os valores a serem subtraídos
                 * - (wasNegative) é a variável que indica que se a interação anterior era um símbolo ne-
                 * gativo ou não
                 * 
                 * *O laço for percorrerá cada campo do numbersForSub. 
                 * *O primeiro if verifica se é um campo vazio, isto ocorre quando temos ou o primeiro sím
                 * bolo de sum é '-' (Ex: -7-56), ou quando existe 2 símbolos '-' seguidos (Ex: 7--56). Is-
                 * to ocorre pois o split divide a string mesmo, o que era uma string agora passa a ser duas.
                 * *Dentro do laço if teremos outra verificação. É a de se o símbolo anterior era '-'. Caso
                 * seja, ele deverá somar o numberForSub[i] atual pois estamos dentro de um split de subs,
                 * ou seja, ela normalmente deveria subtrair. No else é a operação normal. Por fim, temos
                 * que zerar o wasNegative .
                 * *[Else if] aqui temos um XOR do valor de wasNegative, isso ocorre quando temos diversos
                 * '-' seguidos (Ex: 7----5). Esse laço ficará alternando o valor do wasNegative pois dois
                 * '-' se torna '+'. A única exceção é caso o primeiro símbolo de sum seja '-', neste caso
                 * é só ignorar pq na próxima iteração ele irá subtrair do value_sub como tem q fazer.
                 * *Por fim, temos que corrigir um erro da primeira iteração do laço for - ele está subtra-
                 * indo o value em vez de somar caso tenha começado normalmente (Ex: 7-5).
                 * */

                int value_sub = 0;
                string[] numbersForSub = sum.Split('-');
                bool wasNegative = false;

                for(int i=0; i<numbersForSub.Length; i++)
                {
                    if (!numbersForSub[i].Equals(""))
                    {
                        if (wasNegative)
                            value_sub += Mul_Div(numbersForSub[i]);
                        else
                            value_sub -= Mul_Div(numbersForSub[i]);
                        wasNegative = false;
                    }
                    else if (i != 0)
                        wasNegative ^= true;
                }

                if(!numbersForSub[0].Equals(""))
                    value_sub += 2 * Mul_Div(numbersForSub[0]);
                if (swap)
                    value -= value_sub;
                else
                    value += value_sub;
                swap = wasNegative;
            }
            this.value = value;
            return this.value;
        }

        private int Mul_Div(string text)
        {
            string[] numbersToMul = text.Split('*');
            int i,value;

            value = 1;
           
            foreach(string mul in numbersToMul)
            {
                string[] numbersToDiv = mul.Split('/');
                int div_value;
                i = numbersToDiv[0].IndexOf("(_)");

                if (i == -1)
                    div_value = Int32.Parse(numbersToDiv[0]);
                else
                {
                    div_value = soma_negativos(numbersToDiv[0]);
                }

                numbersToDiv = numbersToDiv.Skip(1).ToArray();
                foreach(string div in numbersToDiv)
                {
                    i = div.IndexOf("(_)");
                    if (i == -1)
                        div_value /= Int32.Parse(div);
                    else
                    {
                        div_value /= soma_negativos(div);
                    }
                }

                i = mul.IndexOf("(_)");
                if(i == -1)
                    value *= div_value;
                else 
                {
                    value *= div_value;
                }
            }

            return value;
        }
    }
}
