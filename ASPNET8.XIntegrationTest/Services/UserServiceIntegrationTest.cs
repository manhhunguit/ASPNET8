using ASPNET8.Services;

namespace ASPNET8.XIntegrationTest.Services
{
    public class UserServiceIntegrationTest
    {
        private readonly UserService _userService;

        public UserServiceIntegrationTest()
        {
            var roleService = new RoleService();
            _userService = new UserService(roleService);
        }

        [Fact]
        public void GetByRoleId_ShouldReturnUsers()
        {
            // Arrange
            var roleId = 1;

            // Act
            var users = _userService.GetByRoleId(roleId);

            // Assert
            Assert.NotNull(users);
            Assert.True(users.Any());
        }
    }
}
