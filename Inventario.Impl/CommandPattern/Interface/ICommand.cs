
namespace Inventario.Impl.CommandPattern.Interface
{
    public interface ICommand<T>
    {
         T Execute(IParams param);
    }    
}