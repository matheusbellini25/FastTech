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
        public bool Ativo { get; set; }


        public Pedido() : base() { }

        public Pedido(Guid itemCardapioId, int formaDeEntrega, bool ativo, Guid userId) : base()
        {
            ItemCardapioId = itemCardapioId;
            FormaDeEntrega = formaDeEntrega;
            Ativo = ativo;

            PrepareToInsert(userId);
        }
    }
}
