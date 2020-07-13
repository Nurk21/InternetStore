using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Common
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}
