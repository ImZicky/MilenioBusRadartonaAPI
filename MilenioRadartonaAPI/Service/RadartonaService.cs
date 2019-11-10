using MilenioRadartonaAPI.Models;
using MilenioRadartonaAPI.Relatorios;
using MilenioRadartonaAPI.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IRadartonaService
    {
        Task<List<DesastreRelatorio>> GetDesastre(string lat, string lon, DateTime dia, string raio);
        Task<List<AcidenteRelatorio>> GetAcidente(string lat, string lon, DateTime dia, string raio);
        Task<List<TransitoRelatorio>> GetTransito(string lat, string lon, DateTime dia, string raio);
        Task<List<ChuvaRelatorio>> GetChuva(string lat, string lon, DateTime dia, string raio);
        Task<List<ImprudenciaRelatorio>> GetImprudencia(string lat, string lon, DateTime dia, string raio);
        Task<List<AnormalidadeRelatorio>> GetPrazoLongo(double lat, double lon, DateTime inicio, DateTime fim, double raio);
    }

    public class RadartonaService : IRadartonaService
    {

        private readonly IRadartonaRepository _rep;

        public RadartonaService(IRadartonaRepository rep)
        {
            _rep = rep;
        }


        public async Task<List<AcidenteRelatorio>> GetAcidente(string lat, string lon, DateTime dia, string raio)
        {
            var retorno = await _rep.GetAcidente(lat, lon, dia, raio);
            /* ver como que vai ter que transformar os dados pra criar um relatorio desse tipo */

            return retorno;
        }


        public async Task<List<ChuvaRelatorio>> GetChuva(string lat, string lon, DateTime dia, string raio)
        {
            var retorno = await _rep.GetChuva(lat, lon, dia, raio);
            /* ver como que vai ter que transformar os dados pra criar um relatorio desse tipo */

            return retorno;
        }


        public async Task<List<DesastreRelatorio>> GetDesastre(string lat, string lon, DateTime dia, string raio)
        {
            var retorno = await _rep.GetDesastre(lat, lon, dia, raio);
            /* ver como que vai ter que transformar os dados pra criar um relatorio desse tipo */

            return retorno;
        }


        public async Task<List<ImprudenciaRelatorio>> GetImprudencia(string lat, string lon, DateTime dia, string raio)
        {
            var retorno = await _rep.GetImprudencia(lat, lon, dia, raio);
            /* ver como que vai ter que transformar os dados pra criar um relatorio desse tipo */

            return retorno;
        }

        public Task<List<AnormalidadeRelatorio>> GetPrazoLongo(double lat, double lon, DateTime inicio, DateTime fim, double raio)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TransitoRelatorio>> GetTransito(string lat, string lon, DateTime dia, string raio)
        {
            var retorno = await _rep.GetTransito(lat, lon, dia, raio);
            /* ver como que vai ter que transformar os dados pra criar um relatorio desse tipo */

            return retorno;
        }












    }
}
