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
        Task<DesastreRelatorio> GetDesastre(string lat, string lon, DateTime dia, string raio);
        Task<AcidenteRelatorio> GetAcidente(string lat, string lon, DateTime dia, string raio);
        Task<TransitoRelatorio> GetTransito(string lat, string lon, DateTime dia, string raio);
        Task<ChuvaRelatorio> GetChuva(string lat, string lon, DateTime dia, string raio);
        Task<ImprudenciaRelatorio> GetImprudencia(string lat, string lon, DateTime dia, string raio);
    }


    public class RadartonaRepository : IRadartonaRepository
    {
        public async Task<AcidenteRelatorio> GetAcidente(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<ChuvaRelatorio> GetChuva(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<DesastreRelatorio> GetDesastre(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public Task<ImprudenciaRelatorio> GetImprudencia(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }

        public async Task<TransitoRelatorio> GetTransito(string lat, string lon, DateTime dia, string raio)
        {
            throw new NotImplementedException();
        }




    }





}
