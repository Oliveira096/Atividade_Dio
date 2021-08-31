using System;
using System.Collections.Generic;
using DIO.SERIES.Interfaces;



namespace DIO.SERIES
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void atualizar(int id, Serie Objeto)
        {
           ListaSerie[id] = Objeto;
        }

        public void excluir(int id)
        {
            ListaSerie[id].excluir();
        }

        public void insere(Serie Objeto)
        {
           ListaSerie.Add(Objeto);
        }

        public List<Serie> Lista()
        {
           return ListaSerie;
        }

        public int proximoid()
        {
           return ListaSerie.Count;
        }

        public Serie RetornaPorid(int id)
        {
            return ListaSerie[id] ;
        }
    }
}