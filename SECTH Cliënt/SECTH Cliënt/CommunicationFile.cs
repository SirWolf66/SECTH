﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECTH_Cliënt
{
    public struct CummunicationFile
    {
        private string author;
        private string message;
        private string language;
        private DateTime writeTime;

        public CummunicationFile(string _author, string _message, string _language, DateTime _writeTime)
        {
            author = _author;
            message = _message;
            language = _language;
            writeTime = _writeTime;
        }

        public string Author { get => author; }
        public string Message { get => message; }
        public string Language { get => language; }
        public DateTime WriteTime { get => writeTime; }

        public byte[] ConvertToByteArray()
        {
            return new byte[Convert.ToByte(author) + Convert.ToByte(message) + Convert.ToByte(language) + Convert.ToByte(writeTime)];
        }

    }
}
