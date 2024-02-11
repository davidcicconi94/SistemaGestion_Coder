namespace SistemaGestionData.Exceptions
{
    public class ListNotFoundException<T>: Exception
    {
        public ListNotFoundException(List<T> list, string message)
            :base(message)
        {
            if(list.Count == 0)
            {
                Data.Add("ListaVacia", true);
            }
        }
    }
}
