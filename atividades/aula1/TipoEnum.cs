using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula1;

namespace aula1
{
    public class TipoEnum
    {
        public enum Language
        {
            PTBR, EN,RU
        }

        public Language _language = Language.PTBR;
        public TipoEnum()
        {

        }
            /*
        public TipoEnum (TipoEnum enum)
        {
            _language = enum;
        }
        */

        public Language GetLanguageEnum(string lang)
        {
            switch (lang.ToLower())
            {
                case "portugues":
                    return Language.PTBR;
                case "ingles":
                    return Language.EN;
                case "russo":
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
}