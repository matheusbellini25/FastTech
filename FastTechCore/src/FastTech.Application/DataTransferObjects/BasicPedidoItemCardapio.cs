using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FastTech.Application.DataTransferObjects
{
    public class BasicPedidoItemCardapio
    {
        [JsonPropertyName("ItemCardapioId")]
        [Required(ErrorMessage = "O campo ItemCardapioId é obrigatório.")]
        public Guid ItemCardapioId { get; set; }

        public BasicPedidoItemCardapio() { }

        public BasicPedidoItemCardapio(Guid itemCardapioId)
        {
            ItemCardapioId = itemCardapioId;
        }
    }
}
