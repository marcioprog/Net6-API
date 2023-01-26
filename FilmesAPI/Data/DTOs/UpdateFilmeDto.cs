using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(30)]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string Diretor { get; set; }

    [Required]
    [Range(70, 360, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
