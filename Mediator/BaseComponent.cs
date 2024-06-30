using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class BaseComponent
    {
        protected IChat _chat;

        public BaseComponent(IChat chat = null)
        {
            this._chat = chat;
        }

        public void SetMediator(IChat chat = null)
        {
            this._chat = chat;
        }
    }
}
