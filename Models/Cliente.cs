namespace AgenciaDeViagens.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNasc { get; set; }  
        public string? RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Tel1 { get; set; }
        public string? Tel2 { get; set; }    
        public string? Tel3 { get; set; }
        
       


    }
}
