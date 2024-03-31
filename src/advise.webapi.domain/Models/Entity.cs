using System.ComponentModel.DataAnnotations;

namespace advise.webapi.core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            Deletado = false;
        }
        [Key]
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

        public void Deletar() => Deletado = true;

    }
}

