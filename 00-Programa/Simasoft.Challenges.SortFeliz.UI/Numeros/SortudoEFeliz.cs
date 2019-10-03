using Simasoft.Challenges.SortFeliz.UI.Numeros.Felizes;
using Simasoft.Challenges.SortFeliz.UI.Numeros.Sortudos;

namespace Simasoft.Challenges.SortFeliz.UI.Numeros
{
    public class SortudoEFeliz
    {
        private readonly bool _isSortudo;
        private readonly bool _isFeliz;
        private string _saida;
        private int _numero;
        
        public SortudoEFeliz(int numero)
        {            
            _numero = numero;
           _isSortudo = new NumeroSortudo(numero).IsSortudo;
           _isFeliz = new NumeroFeliz(numero).IsFeliz;
           _saida = ImprimeResultadoGeral();
        }

        public bool isNumeroSortudo()
        {
            return _isSortudo;
        }

        public bool isNumeroFeliz()
        {
            return _isFeliz;
        }

        public string ImprimeResultadoGeral()
        {
            return $"{_numero} - {(isNumeroSortudo() ? "Numero Sortudo" : "Numero Não-Sortudo")} e {(isNumeroFeliz() ? "Feliz" : "Não-Feliz")}";
        }
        
    }
}