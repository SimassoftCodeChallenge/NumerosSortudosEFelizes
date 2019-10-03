using System;
using System.Collections.Generic;

namespace Simasoft.Challenges.SortFeliz.UI.Numeros.Felizes
{
    public class NumeroFeliz
    {
        public NumeroFeliz(int numero)
        {
            IsFeliz = VerificaNumeroFeliz(numero);
        }

        public bool IsFeliz { get; private set; }       

        private bool VerificaNumeroFeliz(int numero)
        {
            int totAlgarismo = 0;
            bool isNumeroFeliz = false;
            bool sairLoop = false;
            var resultadoFinal = 0;
            
            totAlgarismo = numero.ToString().Length;
            resultadoFinal = (int)Math.Pow(numero,2);
            int calculo = 0;
            int soma = numero;
            int valor = numero;;
            int iteracao = 0;
            while(!sairLoop && iteracao <= 100)
            {                                
                iteracao++;                
                calculo = ProcessaSomaAlgarismos(valor,iteracao,out totAlgarismo);
                valor = calculo;
                                                
                if(totAlgarismo == 1){
                    sairLoop = true;
                    if(calculo == 1)
                        isNumeroFeliz = true;                                        
                }
                                      
            }

            return isNumeroFeliz;
        }

        private int ProcessaSomaAlgarismos(int numero,int iteracao, out int totAlgarismo){
            int resultado = 0;
            if(iteracao == 1){
                resultado = (int)Math.Pow(numero,2);
            }else{
                resultado = numero;
            }
                
            int soma = 0;
            for(var i =0;i < resultado.ToString().Length;i++)
            {
                int numeroSoma = (int)resultado.ToString()[i]-'0';
                soma+= (int)Math.Pow(numeroSoma,2);
            } 
            totAlgarismo = soma.ToString().Length;
            return soma;
        }
    }
}