using Microsoft.AspNetCore.Mvc;
using ProEventosAPI.Data;
using ProEventosAPI.Models;

namespace ProEventosAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase {

        private readonly DataContext _dataContext;

        public EventoController(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 6",
                Local = "Fortaleza",
                Lote = "1ro Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Banco de Dados",
                    Local = "Maranguape",
                    Lote = "2do Lote",
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemUrl = "foto2.png",
                    QtdPessoas = 300
                }
        };

        [HttpGet]
        public IEnumerable<Evento> Get() {

            return _dataContext.Eventos;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id) { 
        
            return _dataContext.Eventos.Where(evento => evento.EventoId == id);
        
        }

        [HttpPost]
        public string Post() {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id) {
                return $"Exemplo de put :D = {id}";
            }

        [HttpDelete("{id}")]
        public string Delete(int id) {
            return $"Exemplo de delete = {id}";
        }

        }
    }