using System.Linq;

namespace Simasoft.Challenges.SortFeliz.UI.Numeros.Sortudos
{
    public class NumeroSortudo
    {
        private int[] _listaDeNumeros;
        public NumeroSortudo(int numero)
        {
            _listaDeNumeros = GeraListaDeInteiros(numero);
            IsSortudo = VerificaNumeroSortudo(numero);
        }           

        public bool IsSortudo {get; private set;}

        private bool VerificaNumeroSortudo(int numeroAValidar)
        {
            int multiplo = 0;
            int numero = 0;
            
            //Remove os pares da lista
            _listaDeNumeros = RemoveOsNumerosPares(_listaDeNumeros);

            //Pega sempre o segundo termo da sequencia.
            for(int i = 0;i < _listaDeNumeros.Length;i++)
            {
                int numeroARemover = 0;
                multiplo = _listaDeNumeros[1];                
                for(int j = 0; j < _listaDeNumeros.Length; j++)
                {
                    numero = _listaDeNumeros[j];
                    if(IsMultiplo(numero,multiplo) && (numero != multiplo))
                    {
                        numeroARemover = numero;
                    }
                    _listaDeNumeros = _listaDeNumeros.Where( x => x != numeroARemover).ToArray();
                }                
            } 

            return _listaDeNumeros.Contains(numeroAValidar); 
        }

        private int[] GeraListaDeInteiros(int numero){
            if(numero > 100)
                numero = 100;
            return Enumerable.Range(1, numero).ToArray();
        }

        private int[] RemoveOsNumerosPares(int[] listaNumeros)
        {
            return listaNumeros.Where(x => (x % 2 != 0)).ToArray();
        }

        private bool IsMultiplo(int numero, int resto)
        {
            return numero % resto == 0;
        }        
    }
}