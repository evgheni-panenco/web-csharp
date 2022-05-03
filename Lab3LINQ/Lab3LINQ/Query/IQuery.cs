using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Service
{
    public interface IQuery<T, R>
    {
        List<R> ExecuteQuery(List<T> data);

        String QueryValue();
    }
}
