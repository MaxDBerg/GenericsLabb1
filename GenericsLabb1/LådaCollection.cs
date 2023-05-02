using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabb1
{
    public class LådaCollection : ICollection<Låda>
    {
        private List<Låda> _lådor = new List<Låda>();

        public int Count => _lådor.Count;

        public bool IsReadOnly => false;

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                _lådor.Add(item);
            }
        }

        public void Clear()
        {
            _lådor.Clear();
        }

        public bool Contains(Låda item)
        {
            return _lådor.Contains(item);
        }

        public bool Contains(Låda låda, EqualityComparer<Låda> comparer)
        {
            foreach (var item in _lådor)
            {
                if (comparer.Equals(item, låda))
                {
                    return true;
                }
            }

            return false;
        }


        public void CopyTo(Låda[] array, int arrayIndex)
        {
            _lådor.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return _lådor.GetEnumerator();
        }

        public bool Remove(Låda item)
        {
            return _lådor.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
