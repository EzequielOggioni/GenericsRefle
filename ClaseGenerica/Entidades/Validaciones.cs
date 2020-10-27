using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoy.Clase.Generica
{
    static class Validaciones<T> where T : IComparable
    {

       /// <summary>
        /// Retorna el valor si el valor se encuentra entre el maximo y el minimo, 0 en caso contrario        
        /// </summary>
        /// <param name="minimo"></param>
        /// <param name="maximo"></param>
        /// <param name="valorAValidar"></param>
        /// <returns></returns>
        /// /// <exception cref="System.Exception">Thrown when...</exception>
        public static bool ValidaValor(T minimo, T maximo, T valorAValidar)
        {
            if(minimo.CompareTo(maximo)>0)
                throw new InvalidOperationException("El minimo debe ser mayor al maximo");
            return (valorAValidar.CompareTo(maximo) < 0 && valorAValidar.CompareTo(minimo)>0);
        }
    }
}
