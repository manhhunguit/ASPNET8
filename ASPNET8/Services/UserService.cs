using ASPNET8.Entities;

namespace ASPNET8.Services
{
    public class UserService(RoleService _roleService)
    {
        public IEnumerable<UserEntity>? GetByRoleId(int roleId)
        {
            RoleEntity? role = _roleService.GetById(roleId);

            if (role == null) return null;

            return
            [
                new() {Id = 1, FullName = " User A", Email = "a@gmail.com" },
                new() {Id = 2, FullName = " User B", Email = "b@gmail.com" },
                new() {Id = 3, FullName = " User C", Email = "c@gmail.com" }
            ];
        }
    }
}
