namespace DIO.Series.Interfaces
{
    public interface iRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insert(T entidade);
         void Excui(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
    }
}