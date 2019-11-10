using Microsoft.AspNetCore.Mvc;
using MilenioRadartonaAPI.Models;
using MilenioRadartonaAPI.Relatorios;
using Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MilenioRadartonaAPI.Controllers
{
    public class RadartonaController : Controller
    {
        /*service*/
        private readonly IRadartonaService _serv;

        public RadartonaController(IRadartonaService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        [Route("/v1/GetPrazoLongo/{lat}/{lon}/{inicio}/{fim}/{raio}")]
        public Task<AnormalidadeRelatorio> GetPrazoLongo(double lat, double lon, DateTime inicio, DateTime fim, double raio)
        {
            if (lat != 0 && lon != 0 && fim != null && inicio != null && raio != 0)
            {
                return _serv.GetPrazoLongo(lat, lon, inicio, fim, raio);
            }

            return null;
        }


        [HttpGet]
        [Route("/v1/GetPrazoCurto/{lat}/{lon}/{evento}/{dia}/{raio}")]
        public IActionResult GetPrazoCurto(string lat, string lon, string evento, string dia, string raio)
        {

            if (lat != null && lon != null && evento != null && dia != null && raio != null)
            {
                string eventoFormatado = new CultureInfo("en-US").TextInfo.ToTitleCase(evento);
                string url = "/GetPrazoCurto/Get" + eventoFormatado + "/" + lat + "/" + lon + "/" + dia + "/" + raio;
                return LocalRedirect(url);
            }

            return null;
        }


        [HttpGet]
        [Route("/v1/GetPrazoCurto/GetDesastre/{lat}/{lon}/{dia}/{raio}")]
        public async Task<DesastreRelatorio> GetDesastre(string lat, string lon, DateTime dia, string raio)
        {

            return await _serv.GetDesastre(lat, lon, dia, raio);

        }


        [HttpGet]
        [Route("/v1/GetPrazoCurto/GetAcidente/{lat}/{lon}/{dia}/{raio}")]
        public async Task<AcidenteRelatorio> GetAcidente(string lat, string lon, DateTime dia, string raio)
        {

            return await _serv.GetAcidente(lat, lon, dia, raio);

        }

        [HttpGet]
        [Route("/v1/GetPrazoCurto/GetTransito/{lat}/{lon}/{dia}/{raio}")]
        public async Task<TransitoRelatorio> GetTransito(string lat, string lon, DateTime dia, string raio)
        {

            return await _serv.GetTransito(lat, lon, dia, raio);
        }

        [HttpGet]
        [Route("/v1/GetPrazoCurto/GetChuva/{lat}/{lon}/{dia}/{raio}")]
        public async Task<ChuvaRelatorio> GetChuva(string lat, string lon, DateTime dia, string raio)
        {

            return await _serv.GetChuva(lat, lon, dia, raio);
        }

        [HttpGet]
        [Route("/v1/GetPrazoCurto/GetImprudencia/{lat}/{lon}/{dia}/{raio}")]
        public async Task<ImprudenciaRelatorio> GetImprudencia(string lat, string lon, DateTime dia, string raio)
        {

            return await _serv.GetImprudencia(lat, lon, dia, raio);
        }












    }
}
