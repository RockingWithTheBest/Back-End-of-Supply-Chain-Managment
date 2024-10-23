using AutoMapper;
using Back_End.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using SupplyChain.Repository.Interface;
using xx1.Db;

namespace SupplyChain.Controllers
{
         [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
        [ApiController]
        public class CashController : ControllerBase
        {
            private readonly ApplicationDBContext _context;
            private ICash _cashrepo;
            private readonly IMapper _mapper;

            public CashController(ICash cashrepo, IMapper mapper)
            {
                _cashrepo = cashrepo;
                _mapper = mapper;
            }

            [HttpGet]
            [Route("Index")]
            public IActionResult Index()
            {
                var cashEntities = _cashrepo.GetAll();
                if (cashEntities == null)
                {
                    return NotFound();
                }

                // Map to DTOs
                var cashDtos = _mapper.Map<IEnumerable<CashDto>>(cashEntities);
                return Ok(cashDtos);
            }
        }
    }   

