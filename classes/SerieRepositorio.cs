using System;
using System.Collections.generic;
using DIO.series.Interface;

namespace DIO.series.classes
{
    public class SerieRepositorio : IRepositorio<serie>
    {
        private list<serie> listaSerie = new list<serie>();
        
        public void atualizar(int id, serie objeto)
        {
            listaSerie[Id] = objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(serie entidade)
        {
            listaSerie.Add(objeto);
        }
        public list<serie> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public serie retornaId()
        {
            return listaSerie[id];
        }
        
    }
}