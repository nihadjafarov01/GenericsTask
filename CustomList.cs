using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class CustomList<T>
    {
        T[] _arr = new T[0];
        public int Count { get; private set; } = 0;
        public int Capacity { get; } = 5;
        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }
        public CustomList(int capacity)
        {
            Capacity = capacity <= 0 ? 0 : capacity;
        }
        public CustomList(int capacity, params T[] arr) : this(capacity)
        {
            Capacity = capacity;
            _arr = arr;
            Count = arr.Length;
        }
        public void Add(T num)
        {
            if (Count == _arr.Length)
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
            }
            _arr[Count++] = num;
        }
        public void Clear()
        {
            T[] newArr = new T[0];
            _arr = newArr;
            Count = 0;  
        }
        public bool Exist(T num)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(num))
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(T num)
        {
            T[] newArr = new T[_arr.Length];
            int counter = 0;
            for (int i = 0; i < Count; i++)
            {
                if (!_arr[i].Equals(num))
                {
                    newArr[counter++] = _arr[i];
                }
                else
                {
                    Array.Resize(ref newArr, newArr.Length - 1);
                }
            }
            _arr = newArr;
        }
        
        public void Reverse()
        {
            T[] newArray = new T[_arr.Length];
            for (int i = 0; i < Count; i++)
            {
                newArray[(Count - i) - 1] = _arr[i];
            }
            _arr = newArray;
        }
        public void IndexOf(T num)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(num))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void LastIndexOf(T num)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_arr[i].Equals(num))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
