using FightManagerWebAPI.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FightManagerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    [ApiController]
    public class SettingController : Controller
    {
        DndFightManagerContext _context;

        public SettingController(DndFightManagerContext context)
        {
            _context = context;
        }

        // GET: api/<SettingController>
        /// <summary>
        /// Осуществляет GET-запрос к серверу. Достает из базы данных список сеттингов.
        /// </summary>
        /// <returns>Содержание таблицы сеттингов. Код ответа.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Setting>>> GetSettings()
        {
            return await _context.Settings.ToListAsync();
        }

        // GET api/<SettingController>/5
        /// <summary>
        /// Осуществляет GET-запрос к серверу. Достает из базы данных сеттинг с нужным идентификатором.
        /// </summary>
        /// <param name="id">Идентификатор сеттинга.</param>
        /// <returns>Найденный сеттинг. Код ответа.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Setting>> GetSetting(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var setting = await _context.Settings.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }
            return Ok(setting);
        }

        /// <summary>
        /// Осуществляет POST-запрос к серверу. Добавляет заданный сеттинг в базу данных.
        /// </summary>
        /// <param name="settingInp">Сеттинг для добавления.</param>
        /// <returns>Код ответа.</returns>
        // POST api/<SettingController>
        [HttpPost]
        public async Task<ActionResult<Setting>> Post([FromBody] Setting settingInp)
        {
            Setting setting = new()
            {
                Title = settingInp.Title
            };

            _context.Settings.Add(setting);
            await _context.SaveChangesAsync();
            settingInp.SettingId = setting.SettingId;
            return CreatedAtAction("GetSetting", new { id = settingInp.SettingId }, settingInp);

        }

        /// <summary>
        /// Осуществляет PUT-запрос к серверу. Вносит изменения в заданный сеттинг в базе данных.
        /// </summary>
        /// <param name="id">Идентификатор сеттинга для изменения.</param>
        /// <param name="settingDTO">Экземпляр класса Setting. Содержит данные для замены.</param>
        /// <returns>Код ответа. IEnumerable-список актуальных записей таблицы Setting.</returns>
        // PUT api/<SettingController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<Setting>>> PutSetting(int id, Setting settingDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Setting setting = await _context.Settings.FindAsync(id);

            setting.Title = settingDTO.Title;

            _context.Settings.Update(setting);
            await _context.SaveChangesAsync();
            return await GetSettings();
        }

        /// <summary>
        /// Осуществляет DELETE-запрос к серверу. Удаляет заданный сеттинг из базы данных.
        /// </summary>
        /// <param name="id">Идентфикатор заданного сеттинга.</param>
        /// <returns>Код ответа. IEnumerable-список актуальных записей таблицы Setting.</returns>
        // DELETE api/<SettingController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Setting>>> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var setting = await _context.Settings.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }
            await foreach (var scene in _context.Scenes)
            {
                if (scene.SettingFk == id)
                {
                    _context.Scenes.Remove(scene);
                }
            }

            _context.Settings.Remove(setting);
            await _context.SaveChangesAsync();
            return await GetSettings();
        }
    }
}
