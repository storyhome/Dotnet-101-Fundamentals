using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    interface ICrudRepository<T,TT>
    {

        bool Create(T model);
        void Read();
        bool Update();
        bool Delete();
        TT GetAll();
    }
}
