using TypeModel = Generations.TypeManager.Models.Type;

namespace Generations.TypeManager.Interfaces
{
    public interface iType
    {
        public TypeModel GetTypeById(int id);
        public List<TypeModel> GetTypes();
    }
}
