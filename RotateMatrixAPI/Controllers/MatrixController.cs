
using Microsoft.AspNetCore.Mvc;
using RotateMatrixAPI.Dtos;
using RotateMatrixAPI.Services;
using System;

namespace RotateMatrixAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatrixController : ControllerBase
    {
        private readonly IMatrixService _matrixService;

        public MatrixController(IMatrixService matrixService)
        {
            _matrixService = matrixService;
        }

        [HttpPost("rotate")]
        public ActionResult<RotateMatrixResponse> RotateMatrix([FromBody] RotateMatrixRequest request)
        {
            if (request.Matrix == null || request.Matrix.Length == 0)
            {
                return BadRequest(new { error = "La matriz no puede estar vacía." });
            }

            int n = request.Matrix.Length;
            for (int i = 0; i < n; i++)
            {
                if (request.Matrix[i] == null || request.Matrix[i].Length != n)
                {
                    return BadRequest(new { error = "La matriz debe ser (NxN)." });
                }
            }

            try
            {
                var rotatedMatrix = _matrixService.RotateMatrixCounterClockwise(request.Matrix);
                return Ok(new RotateMatrixResponse { RotatedMatrix = rotatedMatrix });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Ocurrió un error en el servidor.", details = ex.Message });
            }
        }
    }
}
