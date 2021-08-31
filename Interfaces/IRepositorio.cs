using System.Collections.Generic;
namespace DIO.SERIES.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorid(int id);
        void insere(T entidade);
        void excluir(int id);
        void atualizar(int id, T entidade);

        int proximoid();
    }
}