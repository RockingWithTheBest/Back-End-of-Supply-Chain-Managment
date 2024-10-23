using AutoMapper;
using Back_End.Models;
using Back_End.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using xx1.Db;

namespace Back_End.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ChequeController: ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private ICheque _chequerepo;
        private readonly IMapper _mapper;
        public ChequeController(ICheque chequerepo, IMapper mapper)
        {
            _chequerepo = chequerepo;
            _mapper = mapper;
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Index")]
        public IActionResult Index()
        {
            var chequeEntities = _chequerepo.GetAll();
            if (chequeEntities == null)
            {
                return NotFound();
            }
            // Map to DTOs
            var chequeDtos = _mapper.Map<IEnumerable<ChequeDto>>(chequeEntities);
            return Ok(chequeDtos);
            
        }
    }
}
