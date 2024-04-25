namespace Api.Restaurante.Entities
{
    public class Prato
    {
        public int PratoId { get; set; }   
        public string PratoNome { get; set; }
        public string PratoDescricao { get; set; }
        public double PratoValorUnit { get; set; }
        public bool Ativo {  get; set; }    
    }
}
