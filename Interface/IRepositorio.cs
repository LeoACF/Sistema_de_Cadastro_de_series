using System.Collections.generic;

namespace DIO.series.Interface
{
    public interface IRepositorio<I>
    {
         List<I> Lista();

         I retornaId(int id);

         void Insere(I entidade);

         void exclui(int id);

         void Atualiza(int id, entidade);
         
         int ProximoId();
    }
}