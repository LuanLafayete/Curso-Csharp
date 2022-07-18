using System;

namespace Generics1.Service
{
    class PrinterService
    {
        private int[] _value = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _value[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _value[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_value[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_value[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
