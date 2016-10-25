using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class GenericListEnumerator<T> : IEnumerator<T>
    {
        private int _current;
        private GenericList<T> _list;

        public GenericListEnumerator(GenericList<T> list)
        {
            this._list = list;
            _current = -1;
        }


        public Boolean MoveNext()
        {
            if (++_current >= _list.Count)
                return false;
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _current=-1;
        }

        public T Current
        {
            get
            {
                return _list.GetElement(_current);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
