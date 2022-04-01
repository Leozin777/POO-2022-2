namespace AgendaContatos.Domain
{
    public class Contato
    {
        public Contato(string nome, string fone)
        {
            Nome = nome;
            Fone = fone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        

    }
}