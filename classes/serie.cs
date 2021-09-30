namespace DIO.series.classes
{
    public class series : entidadebase
    {
        private Genero Genero{ get; set;}

        private string titulo{ get; set;}
        
        private string Descricao {get; set;}

        private int ano{ get; set;}

        private bool Excluido{get; set;}
    }
        public Serie(int ID, Genero genero, string Titulo, string Descricao, int Ano)
    {}
        this.Id = Id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = Descricao;
        this.Ano = ano;
        this.Excluido = false;
    
    public override string toString()
    {
        string retorno = "";
        retorno +="Genero" + this.Genero + Environment.newLine;
        retorno +="titulo" + this.titulo + Environment.newLine;
        retorno +="Descricao" + this.Descricao + Environment.newLine;
        retorno +="ano" + this.ano + Environment.newLine;
        retorno +="Excluido" + this.Excluido;

        return retorno;
    }
    public string retornaTitulo()
    {
        return this.titulo;
    }
    public int retornaId()
    {
        return this.Id;
    }
    public bool retornaExcluido()
    {
        return this.Excluido;
    }
    public void Exclui()
    {
        this.Excluido = true;
    }
}