using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class MiPropiaException: Exception
    {
      public MiPropiaException() : base("Esta es mi excepcion")
      {

      }
        
      public MiPropiaException(string message): base(message)
      {

      }

      public MiPropiaException(string message,Exception inner): base(message,inner)
      {
      }
    }   
}
