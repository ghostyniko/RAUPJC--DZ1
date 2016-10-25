using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class GenericList <X>:IGenericList <X>
    {
        private X[] _internalStorage;
        private int _count;

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initilalSize)
        {
            int value = initilalSize;
            if (initilalSize < 0)
            {
                Console.WriteLine("Size of an generic list cannot be a negative value. Setting initial value to default size.");
                value = 4;
            }
            _internalStorage = new X[value];
            _count = -1;
        }

        public void Add(X item)
        {
            if (_internalStorage.Length - 1 == _count)
            {
                X[] temp = _internalStorage;
                _internalStorage = new X[2 * temp.Length];
                temp.CopyTo(_internalStorage, 0);
            }
            _internalStorage[++_count] = item;

        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > _count)
            {
                Console.WriteLine("The given index is out of the range.");
                return false;
            }
            for (int i = index; i < _count; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _count--;
            return true;
        }

        public bool Remove(X item)
        {
            /* int index = 0;
             while (index <= _count || _internalStorage[index] != item) index++;*/
            int index = IndexOf(item);
            return RemoveAt(index);
        }

        public X GetElement(int index)
        {
            try
            {
                if (index < 0 || index > _count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                else
                {
                    return _internalStorage[index];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e);
                return _internalStorage[0];
            }

        }

        public int Count
        {
            get
            {
                return _count + 1;
            }
        }

        public void Clear()
        {
            _count = -1;
        }

        public bool Contains(X item)
        {
            for (int index = 0; index <= _count; index++)
                if (item.Equals(_internalStorage[index])) return true;
            return false;
        }

        public int IndexOf(X item)
        {
            for (int index = 0; index <= _count; index++)
            {
                if (item.Equals(_internalStorage[index])) return index;
            }
            return -1;
        }

        public void print()
        {
            System.Console.WriteLine("Element of the list are: ");
            for (int i = 0; i <= _count; i++)
            {
                System.Console.Write("{0} ", _internalStorage[i]);
            }
            System.Console.WriteLine("");
        }

        
    }

}

