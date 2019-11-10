using MilenioRadartonaAPI.Models;
using MilenioRadartonaAPI.Relatorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace MilenioRadartonaAPI.Repository
{
    public interface IRadartonaRepository
    {
        Task<List<DesastreRelatorio>> GetDesastre(string lat, string lon, DateTime dia, string raio);
        Task<List<AcidenteRelatorio>> GetAcidente(string lat, string lon, DateTime dia, string raio);
        Task<List<TransitoRelatorio>> GetTransito(string lat, string lon, DateTime dia, string raio);
        Task<List<ChuvaRelatorio>> GetChuva(string lat, string lon, DateTime dia, string raio);
        Task<List<ImprudenciaRelatorio>> GetImprudencia(string lat, string lon, DateTime dia, string raio);

    }


    public class RadartonaRepository : IRadartonaRepository
    {
        public async Task<List<AcidenteRelatorio>> GetAcidente(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ChuvaRelatorio>> GetChuva(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DesastreRelatorio>> GetDesastre(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImprudenciaRelatorio>> GetImprudencia(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TransitoRelatorio>> GetTransito(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }




    }





}
