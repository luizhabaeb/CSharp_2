using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restriction_Generics.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable //A minha lista é de um tipo T, desde que o T seja ICOMPARABLE > compara um objeto com outro
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty.");
            }

            T max = list[0];
            for (int i = 1; i< list.Count; i++) //Comecei com 1 porque o elemento 0 já está salvo na variável 'max'
            {
                if (list[i].CompareTo(max) > 0) //Comparando o list i com Max e comparando de se é maior do que 0 - DE FORMA GENÉRICA
                {
                    max = list[i];  
                }
            }
            return max;
        }
    }
}
