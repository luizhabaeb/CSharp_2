using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tipo 'T' > Tipo genérico, pois teremos a operação de adicionar um valor do tipo T
//Na hora de declarar o objeto, especificar QUAL o tipo T que queremos

namespace Generics
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];   //Variável interna que poderá armazenar 10 inteiros

        private int _count = 0; //Variável para contar quantos inteiros adicionei

        public void AddValue(T value)
        {
            if (_count == 10)  //Programação defensiva - se o count for = 10, o array já esta cheio.
            {
                throw new InvalidOperationException("PrintService is already full.");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty.");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
        }

    }
}