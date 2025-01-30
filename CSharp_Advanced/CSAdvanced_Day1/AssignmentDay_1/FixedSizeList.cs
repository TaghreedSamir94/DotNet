using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay_1
{
    internal class FixedSizeList<T>
    {
        public int Capcity { get; set; }
        private List<T> _list;

        public FixedSizeList(int cap) 
        {
            if (cap <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _list = new List<T>(Capcity);
            Capcity = cap;
        }

        public void AddList(T element)
        {
            if(_list.Count >= Capcity)
            {
                throw new InvalidOperationException(" The list is full.");
            }
            _list.Add(element);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Capcity)
            {
                throw new InvalidOperationException("Invalid Index");
            }
            return _list[index];
        }


    }
}
