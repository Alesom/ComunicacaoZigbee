using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AgrupaDados
    {
        public AgrupaDados()
        {
            Principal = string.Empty;
            Full = false;
        }

        private string Principal;
        private Boolean Full; //indica se a string esta completa, ou seja, se tem \n\r


        private Boolean getisFull()
        {
            return Full;
        }

        private void setisFull(Boolean NFull)
        {
           Full=NFull;
        }

        public Boolean Central(string Word)
        {
            if (this.getisFull())
                return false;
            else
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    char A = Word[i];
                    if (A == '\n' || A == '\r')
                    {
                        this.ConcatenaStrings(Word);
                        Console.WriteLine("oi");
                        setisFull(false);
                        return false;
                    }
                    
                }

                this.ConcatenaStrings(Word);
                return true;
            }
        }

        public string getPrincipal()
        {
            return Principal;
        }

        public void setPrincipal(string neWord)
        {
            Principal=neWord;
        }

        private void ConcatenaStrings(string soma)
        {
            Principal+=soma;
        }


    }
}
