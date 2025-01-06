using Microsoft.AspNetCore.Mvc;
using Serilog_JWT_Other.Models.Author;
using Serilog_JWT_Other.Services;
using System.Text.Json;

namespace Serilog_JWT_Other.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(AuthorService service, ILogger<AuthorController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        [Route("CreateAuthor")]
        public IActionResult CreateAuthor(CreateAuthorRequestModel model)
        {
            _logger.LogInformation("CreateAuthor executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(model));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.CreateAuthor(model);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("CreateAuthor Finished ...");
            }

        }

        [HttpGet]
        [Route("GetAuthorById")]

        public IActionResult GetAuthorByIdHttpGet(string id)
        {
            _logger.LogInformation("GetAuthorById with HttpGet executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(id));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var model = new GetAuthorByIdRequestModel { Id = id };
                var result = _service.GetAuthorById(model);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("GetAuthorById with HttpGet Finished ...");
            }
        }

        [HttpPost]
        [Route("GetAuthorById")]

        public IActionResult GetAuthorById(GetAuthorByIdRequestModel model)
        {

            _logger.LogInformation("GetAuthorById with HttpPost executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(model));


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetAuthorById(model);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("GetAuthorById with HttpPost Finished ...");
            }
        }

        [HttpPost]
        [Route("GetAuthorList")]

        public IActionResult GetAuthorList(GetAuthorListRequestModel model)
        {
            _logger.LogInformation("GetAuthorList executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(model));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetAuthorList(model);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("GetAuthorList Finished ...");
            }
        }

        [HttpPost]
        [Route("UpdateAuthorById")]

        public IActionResult UpdateAuthorById(UpdateAuthorByIdRequestModel model)
        {
            _logger.LogInformation("UpdateAuthorById executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(model));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.UpdateAuthorById(model);

                if (result != null)
                {
                    return Ok("Succesfully Updated");
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("UpdateAuthorById Finished ...");
            }
        }


        [HttpPost]
        [Route("DeleteAuthorById")]

        public IActionResult DeleteAuthorById(DeleteAuthorByIdRequestModel model)
        {
            _logger.LogInformation("DeleteAuthorById executing ....");
            _logger.LogInformation("Request: " + JsonSerializer.Serialize(model));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.DeleteAuthorById(model);

                if (result != null)
                {
                    return Ok("Successfully Deleted");
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                _logger.LogError("Error Response Catch: " + JsonSerializer.Serialize(ex));
                return BadRequest(message);
            }
            finally
            {
                _logger.LogInformation("DeleteAuthorById Finished ...");
            }
        }
    }
}
