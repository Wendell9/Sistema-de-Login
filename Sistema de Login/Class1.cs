using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MinhaException : Exception
{
    public MinhaException() { }
    public MinhaException(string message) : base(message) { }
    public MinhaException(string message, Exception innerException) : base(message, innerException) { }
}

