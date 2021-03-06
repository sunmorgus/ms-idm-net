using System;
using System.Collections.Generic;
using IdmNet.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable ObjectCreationAsStatement
// ReSharper disable UseObjectOrCollectionInitializer

namespace IdmNet.Models.Tests
{
    [TestClass]
    public class SearchScopeConfigurationTests
    {
        private SearchScopeConfiguration _it;

        public SearchScopeConfigurationTests()
        {
            _it = new SearchScopeConfiguration();
        }

        [TestMethod]
        public void It_has_a_paremeterless_constructor()
        {
            Assert.AreEqual("SearchScopeConfiguration", _it.ObjectType);
        }

        [TestMethod]
        public void It_has_a_constructor_that_takes_an_IdmResource()
        {
            var resource = new IdmResource
            {
                DisplayName = "My Display Name",
                Creator = new Person { DisplayName = "Creator Display Name", ObjectID = "Creator ObjectID"},
            };
            var it = new SearchScopeConfiguration(resource);

            Assert.AreEqual("SearchScopeConfiguration", it.ObjectType);
            Assert.AreEqual("My Display Name", it.DisplayName);
            Assert.AreEqual("Creator Display Name", it.Creator.DisplayName);
        }

        [TestMethod]
        public void It_has_a_constructor_that_takes_an_IdmResource_without_Creator()
        {
            var resource = new IdmResource
            {
                DisplayName = "My Display Name",
            };
            var it = new SearchScopeConfiguration(resource);

            Assert.AreEqual("My Display Name", it.DisplayName);
            Assert.IsNull(it.Creator);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void It_throws_when_you_try_to_set_ObjectType_to_anything_other_than_its_primary_ObjectType()
        {
            _it.ObjectType = "Invalid Object Type";
        }

        [TestMethod]
        public void It_can_get_and_set_msidmSearchScopeAdvancedFilter()
        {
            // Act
            _it.msidmSearchScopeAdvancedFilter = "A string";

            // Assert
            Assert.AreEqual("A string", _it.msidmSearchScopeAdvancedFilter);
        }


        [TestMethod]
        public void It_can_get_and_set_SearchScopeColumn()
        {
            // Act
            _it.SearchScopeColumn = "A string";

            // Assert
            Assert.AreEqual("A string", _it.SearchScopeColumn);
        }


        [TestMethod]
        public void It_can_get_and_set_SearchScopeContext()
        {
            var subObject1 = "foo1";
            var subObject2 = "foo2";
            var list = new List<string> { subObject1, subObject2 };

            // Act
            _it.SearchScopeContext = list; 

            // Assert
            Assert.AreEqual("foo1", _it.SearchScopeContext[0]);
            Assert.AreEqual("foo2", _it.SearchScopeContext[1]);
        }


        [TestMethod]
        public void It_has_IsConfigurationType_which_is_null_by_default()
        {
            // Assert
            Assert.IsNull(_it.IsConfigurationType);
        }

        [TestMethod]
        public void It_has_IsConfigurationType_which_can_be_set_back_to_null()
        {
            // Arrange
            _it.IsConfigurationType = true;

            // Act
            _it.IsConfigurationType = null;

            // Assert
            Assert.IsNull(_it.IsConfigurationType);
        }

        [TestMethod]
        public void It_can_get_and_set_IsConfigurationType()
        {
            // Act
            _it.IsConfigurationType = true;

            // Assert
            Assert.AreEqual(true, _it.IsConfigurationType);
        }


        [TestMethod]
        public void It_can_get_and_set_NavigationPage()
        {
            // Act
            _it.NavigationPage = "A string";

            // Assert
            Assert.AreEqual("A string", _it.NavigationPage);
        }


        [TestMethod]
        public void It_can_get_and_set_Order()
        {
            // Act
            _it.Order = 123;

            // Assert
            Assert.AreEqual(123, _it.Order);
        }


        [TestMethod]
        public void It_can_get_and_set_SearchScopeTargetURL()
        {
            // Act
            _it.SearchScopeTargetURL = "A string";

            // Assert
            Assert.AreEqual("A string", _it.SearchScopeTargetURL);
        }


        [TestMethod]
        public void It_can_get_and_set_SearchScopeResultObjectType()
        {
            // Act
            _it.SearchScopeResultObjectType = "A string";

            // Assert
            Assert.AreEqual("A string", _it.SearchScopeResultObjectType);
        }


        [TestMethod]
        public void It_can_get_and_set_SearchScope()
        {
            // Act
            _it.SearchScope = "A string";

            // Assert
            Assert.AreEqual("A string", _it.SearchScope);
        }


        [TestMethod]
        public void It_can_get_and_set_UsageKeyword()
        {
            var subObject1 = "foo1";
            var subObject2 = "foo2";
            var list = new List<string> { subObject1, subObject2 };

            // Act
            _it.UsageKeyword = list; 

            // Assert
            Assert.AreEqual("foo1", _it.UsageKeyword[0]);
            Assert.AreEqual("foo2", _it.UsageKeyword[1]);
        }


    }
}
