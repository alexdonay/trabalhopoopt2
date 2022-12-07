using System.Collections.Generic;

namespace trabalhopoopt2
{

    sealed class BancoDados
    {
        public List<Cliente> Clientes = new List<Cliente>();
        private BancoDados() { }
        private static BancoDados _instance;
        public static BancoDados getInstance()
        {
            if (_instance == null)
            {
                _instance = new BancoDados();
            }
            return _instance;
        }

    }
}
