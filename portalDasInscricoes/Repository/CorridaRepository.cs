using portalDasInscricoes.Models;

namespace portalDasInscricoes.Repository
{
    public static class CorridaRepository
    {
        private static List<CorridaModel> _corridas = new List<CorridaModel>();
        private static int _nextId = 1;

        public static List<CorridaModel> Listar() => _corridas;

        public static void Adicionar(CorridaModel corrida)
        {
            corrida.Id = _nextId++;
            _corridas.Add(corrida);
        }
    }

}
