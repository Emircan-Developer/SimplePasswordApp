using com.Keys.SetKey.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Keys.SetKey.Manager
{
    public class InterfaceManager
    {
        IGenerate _IGenerate;
        Texts text;
        string[] inputValue;
        public InterfaceManager(IGenerate Generate,Texts text,string[] inputValue)
        {
            this.inputValue = inputValue;
            this.text = text;
            
            _IGenerate = Generate;
        }
        public string GeneratePassword()
        {
            return _IGenerate.Generate(text,inputValue);
        }
    }
}
