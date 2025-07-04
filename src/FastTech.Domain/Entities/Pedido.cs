using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTech.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public Guid ItemCardapioId { get; set; }
        public int FormaDeEntrega { get; set; }

        public Pedido() : base() { }

        public Pedido(Guid itemCardapioId, int formaDeEntrega, Guid userId) : base()
        {
            ItemCardapioId = itemCardapioId;
            FormaDeEntrega = formaDeEntrega;

            PrepareToInsert(userId);
        }
    }
}
