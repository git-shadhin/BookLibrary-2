using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COUCHEERROR
{
    public class CustomException : Exception
    {
        public CustomException()
            : base()
        {
        }

        public CustomException(string msg)
            : base(msg)
        {
        }

        public CustomException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }

        public CustomException(string msg, NullReferenceException nre)
            : base(msg, nre)
        {
        }
    }
}
