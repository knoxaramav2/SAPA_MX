using System;
using System.Collections.Generic;
using System.Text;

namespace FileBroker
{
    interface IBroker<T>
    {
        T Load();
        T Save();
    }
}
