using System;
using System.Xml.Serialization;
using CSharpFundamentals.Basics;

namespace CSharpFundamentals {
    public class Program {

        static void Main(string[] args) {
            Indentifiers.Init();
            Variables.CompileTimeInit();
            Variables.RunTimeInit();
            DataTypes.ValTypes();
            DataTypes.RefTypes();
            DataTypes.PointerTypes();
        }
    }
}