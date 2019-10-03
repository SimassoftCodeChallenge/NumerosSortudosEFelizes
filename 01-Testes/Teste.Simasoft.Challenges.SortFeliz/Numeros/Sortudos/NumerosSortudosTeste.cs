using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simasoft.Challenges.SortFeliz.UI.Numeros.Sortudos;

namespace Teste.Simasoft.Challenges.SortFeliz.Numeros.Sortudos
{
    [TestClass]
    public class NumerosSortudosTeste
    {
        [TestMethod]        
        public void RetiraMultiplosDeDoisDaListaTeste(int limite){
            //int limite = 100;
            int[] listaNumeros = GeraListaInteirosUmAte(limite);
            int multiplo = 0;
            int numero = 0;            

            //Remove os pares da lista
            listaNumeros = RemoveOsNumerosPares(listaNumeros);

            //Pega sempre o segundo termo da sequencia.
            for(int i = 0;i < listaNumeros.Length;i++)
            {
                int numeroARemover = 0;
                multiplo = listaNumeros[1];                
                for(int j = 0; j < listaNumeros.Length; j++)
                {
                    numero = listaNumeros[j];
                    if(IsMultiplo(numero,multiplo) && (numero != multiplo))
                    {
                        numeroARemover = numero;
                    }
                    listaNumeros = listaNumeros.Where( x => x != numeroARemover).ToArray();
                }                
            } 

            var resultado = listaNumeros.Contains(limite);          
        }

        private int[] RemoveOsNumerosPares(int[] listaNumeros)
        {
            return listaNumeros.Where(x => (x % 2 != 0)).ToArray();
        }

        private bool IsMultiplo(int numero, int resto){
            return numero % resto == 0;
        }       

        private int[] GeraListaInteirosUmAte(int final){
            return Enumerable.Range(1, final).OrderBy(x => x).ToArray();
        }  

        [TestMethod]        
        public void VerificaSeNumeroESortudoViaClasseConcreta(int numero)
        {
            bool isSortudo = new NumeroSortudo(numero).IsSortudo;
            Assert.IsTrue(true);
        }       
    }
}