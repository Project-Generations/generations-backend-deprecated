using Generations.TypeManager.Interfaces;
using MySqlConnector;
using TypeEntity = Generations.DA.Entities.Types;
using TypeModel = Generations.TypeManager.Models.Type;

namespace Generations.DA.Data
{
    public class TypeDA : iType
    {
        private readonly DataContext dataContext;

        public TypeDA(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public TypeModel GetTypeById(int id)
        {
            using (dataContext)
            {
                try
                {
                    TypeEntity getTypes = dataContext.Types.Single(type => type.Id == id);

                    TypeModel type = new()
                    {
                        Id = getTypes.Id,
                        Name = getTypes.Name,
                    };

                    return type;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }

            throw new NotImplementedException();
        }

        public List<TypeModel> GetTypes()
        {
            using (dataContext)
            {
                try
                {
                    var _types = dataContext.Types.ToList();
                    List<TypeModel> types = new();

                    foreach (var _type in _types)
                    {
                        TypeModel type = new()
                        {
                            Id = _type.Id,
                            Name = _type.Name,
                        };

                        types.Add(type);
                    }

                    return types;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }
    }
}
