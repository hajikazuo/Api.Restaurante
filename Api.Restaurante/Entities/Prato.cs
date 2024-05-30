using System.ComponentModel.DataAnnotations;

namespace Api.Restaurante.Entities
{
    public class Prato
    {
        public int PratoId { get; set; }
        [MaxLength(100)]
        public string PratoNome { get; set; }
        [MaxLength(500)]
        public string PratoDescricao { get; set; }
        public double PratoValorUnit { get; set; }
        [MaxLength(500)]
        public string UrlImg { get; set; }
        public bool Ativo {  get; set; }    
    }
}
