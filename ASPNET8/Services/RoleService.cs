using ASPNET8.Entities;

namespace ASPNET8.Services
{
    public class RoleService
    {
        public virtual RoleEntity? GetById(int id)
        {
            if (id != 1) return null;
            
            return new() { Id = 1, Name = "Administrator" };
        }
    }
}
