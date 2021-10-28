using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibrary
{
    [TestFixture]
    public class UserTest
    {
        /// <summary>
        /// Method ini akan mencocokan username dan password yang diberikan
        /// dengan username dan password yang terdaftar dalam database.
        /// </summary>
        /// <param name="userName">Diisi dengan user name</param>
        /// <param name="password">Diisi dengan password</param>
        /// <returns>
        /// Apabila cocok, akan menghasilkan true, dan apabila tidak cocok akan menghasilkan false.
        /// </returns>
       
        [Test]
        public void TestUserValid()
        {
            User user = new User();
            string userName = "user name";
            string password = "password";
            bool expected = true;
            bool actual;
            actual = user.IsValidUser(userName, password);
            Assert.AreEqual(expected, actual);
        }
    }
}
