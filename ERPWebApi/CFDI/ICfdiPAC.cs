using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.CFDI
{
    public interface ICfdiPAC
    {
        bool CancelCFDI();

        bool GetCFDI();
    }
}
