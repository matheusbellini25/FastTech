using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FastTech.Application.DataTransferObjects
{
    public class BasicPedido
    {
        [JsonPropertyName("itemCardapioId")]
        [Required(ErrorMessage = "O campo ItemCardapioId é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public Guid ItemCardapioId { get; set; }

        [JsonPropertyName("formaDeEntrega")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(300, ErrorMessage = "A descrição pode ter no máximo 300 caracteres.")]
        public int FormaDeEntrega { get; set; }

        public BasicPedido() : base() { }

        public BasicPedido(Guid itemCardapioId, int formaDeEntrega)
        {
            ItemCardapioId = itemCardapioId;
            FormaDeEntrega = formaDeEntrega;
        }
    }
}
