using ASPNET8.Entities;
using ASPNET8.Services;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET8.XUnitTest.Services
{
    public class UserServiceTest
    {
        private readonly RoleService _roleService = A.Fake<RoleService>();
        private readonly UserService _userService;

        public UserServiceTest()
        {
            _userService = new UserService(_roleService);
        }

        [Fact]
        public void GetByRoleId_ShouldReturnNull_IfRoleDoesNotExist()
        {
            // Arrange
            var roleId = 0;

            A.CallTo(() => _roleService.GetById(roleId)).Returns(null);

            // Act
            var users = _userService.GetByRoleId(roleId);

            // Assert
            Assert.Null(users);
        }

        [Fact]
        public void GetByRoleId_ShouldReturnUsers_IfRoleExists()
        {
            // Arrange
            var roleId = 1;

            var roleEntity = new RoleEntity { Id = 1, Name = "Administrator" };
            A.CallTo(() => _roleService.GetById(roleId)).Returns(roleEntity);

            // Act
            var users = _userService.GetByRoleId(roleId);

            // Assert
            Assert.NotNull(users);
            Assert.True(users.Any());
        }
    }
}
