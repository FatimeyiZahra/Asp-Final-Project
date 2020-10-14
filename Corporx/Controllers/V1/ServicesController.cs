using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Corporx.Resources;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Corporx.Controllers.V1
{
    [Route("v1/home")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ServicesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [Route("services")]
        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await _unitOfWork.Service.GetAllAsync();

            var servicesResources = _mapper.Map<IEnumerable<Services>, IEnumerable<ServicesResource>>(services);
                                               
            //return Ok(servicesResources);

            //var qualityWork = await _unitOfWork.QualityWork.GetAllAsync();
            //var qualityWorkResources = _mapper.Map<IEnumerable<QualityWork>, IEnumerable<QualityWorkResource>>(qualityWork);

            return Ok(servicesResources);

        }
        [Route("qualityWork")]
        [HttpGet]
        public async Task<IActionResult> GetQualityWork()
        {
            var qualityWork = await _unitOfWork.QualityWork.GetAllAsync();
            var qualityWorkResources = _mapper.Map<IEnumerable<QualityWork>, IEnumerable<QualityWorkResource>>(qualityWork);

            return Ok(qualityWorkResources);

        }

        [Route("news")]
        [HttpGet]
        public async Task<IActionResult> GetNews()
        {
            var news = await _unitOfWork.News.GetAllNewWithCategories();

            var newsResources = _mapper.Map<IEnumerable<News>, IEnumerable<NewsResource>>(news);


            return Ok(newsResources);

        }

        [Route("team")]
        [HttpGet]
        public async Task<IActionResult> GetTeam()
        {
            var team = await _unitOfWork.Team.GetTeamsWithPhotoAsync();

            var teamResources = _mapper.Map<IEnumerable<Team>, IEnumerable<TeamResource>>(team);

            return Ok(teamResources);

        }
        [Route("client")]
        [HttpGet]
        public async Task<IActionResult> GetClient()
        {
            var client = await _unitOfWork.Client.GetAllAsync();

            var clientResources = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientResource>>(client);

            return Ok(clientResources);

        }
        [Route("corporx")]
        [HttpGet]
        public async Task<IActionResult> GetCorporx()
        {
            var corporx = await _unitOfWork.Corporx.GetAllAsync();

            var corporxResources = _mapper.Map<IEnumerable<Data.Entities.Corporx>, IEnumerable<CorporxResource>>(corporx);

            return Ok(corporxResources);

        }


    }
}
