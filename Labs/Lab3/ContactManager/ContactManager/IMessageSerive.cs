using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    interface IMessageSerive
    {

        Message Send( Message message );
    }
}
