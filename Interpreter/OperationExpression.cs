using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class OperationExpression : IExpression
    {
        private string _value;

        public OperationExpression(string token)
        {
            _value = token;
        }

        public void Interpret(Context context)
        {
            context.setOperation(_value);
        }
    }
}
