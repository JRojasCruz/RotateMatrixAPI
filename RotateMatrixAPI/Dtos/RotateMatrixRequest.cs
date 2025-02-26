using System.ComponentModel.DataAnnotations;

namespace RotateMatrixAPI.Dtos
{
    public class RotateMatrixRequest
    {
        [Required(ErrorMessage = "El campo 'Matrix' es requerido.")]
        public int[][] Matrix { get; set; }
    }
}
