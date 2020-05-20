using com.Keys.SetKey.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Keys.SetKey.Manager
{
    class GenerateMethod1 : IGenerate
    {
        public string Generate(Texts texts,string[] text)
        {
            string Password = "";
            for(int i = 0; i < texts.Alphabets.Length; i++)
            {
                foreach(var x in text)
                {
                    if(x == texts.Alphabets[i])
                    {
                        Password += texts.GenerateALphabets[i];
                    }

                }
            }
            return Password;
        }
    }
}
