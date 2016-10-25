using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAUPJC_1_Assignment
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _count;
        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initilalSize)
        {
            int value = initilalSize;
            if (initilalSize < 0)
            {
                Console.WriteLine("Size of an integer list cannot be a negative value. Setting initial value to default size./n");
                value = 4;
            }
            _internalStorage = new int[value];
            _count = -1;
        }

        public void Add(int item)
        {
            if (_internalStorage.Length - 1 == _count)
            {
                int[] temp = _internalStorage;
                _internalStorage = new int[2 * temp.Length];
                temp.CopyTo(_internalStorage, 0);
            }
                _internalStorage[++_count] = item;

        }

        public bool RemoveAt(int index)
        {
            if (index<0 || index>_count)
            {
                Console.WriteLine("The given index is out of the range.");
                return false;
            }
            for (int i=index;i<_count;i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _count--;
            return true;
        }

        public bool Remove(int item)
        {
            /* int index = 0;
             while (index <= _count || _internalStorage[index] != item) index++;*/
            int index = IndexOf(item);
            return RemoveAt(index);
        }

        public int GetElement(int index)
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
                return 0;
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

        public bool Contains(int item)
        {
            for (int index = 0; index <= _count; index++)
                if (_internalStorage[index] == item) return true;
            return false;
        }

        public int IndexOf(int item)
        {
            for (int index=0;index<=_count; index++)
            {
                if (_internalStorage[index] == item) return index;
            }
            return -1;
        }

        public void print()
        {
            System.Console.WriteLine("Element of the list are: ");
            for(int i=0;i<=_count;i++)
            {
                System.Console.Write("{0} ", _internalStorage[i]);
            }
            System.Console.WriteLine("");
        }
    }

   

}
