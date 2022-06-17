using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Data.Interface {
    public interface IRules<T> {

        void ValidationInsert(T obj);
        void ValidationUpdate(T obj);

    }
}
