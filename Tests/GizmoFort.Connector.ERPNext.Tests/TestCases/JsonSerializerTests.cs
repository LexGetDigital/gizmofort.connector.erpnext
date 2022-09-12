using GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using Xunit.Sdk;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    public class JsonSerializerTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public JsonSerializerTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void SerializeCustomerTest()
        {
            // Arrange

            var customer = new ERP_Selling_Customer();
            customer.Name = "Generic Test Customer";
            customer.Owner = "admin@my.erpnext.com";
            customer.Creation = DateTime.Parse("2022-09-12T14:46:12.845619Z");
            customer.Disabled = 0;
            customer.IsFrozen = 0;
            customer.Language = "en";
            customer.Modified = DateTime.Parse("2022-09-12T14:46:12.845619Z");
            customer.Docstatus = 0;
            customer.Territory = "United States";
            customer.DnRequired = 0;
            customer.ModifiedBy = "admin@my.erpnext.com";
            customer.SoRequired = 0;
            customer.CustomerName = "Generic Test Customer";
            customer.CustomerType = "Company";
            customer.NamingSeries = "CUST-.YYYY.-";
            customer.CustomerGroup = "Individual";
            customer.ExemptFromSalesTax = 0;
            customer.DefaultCommissionRate = 0;

            // Act

            var actual = ERPNextObjectBase.Serialize(customer)!;

            // Assert 

            var expected = "{\"Name\":\"Generic Test Customer\",\"Owner\":\"admin@my.erpnext.com\",\"Creation\":\"2022-09-12T14:46:12.8456190Z\",\"Disabled\":0,\"IsFrozen\":0,\"Language\":\"en\",\"Modified\":\"2022-09-12T14:46:12.8456190Z\",\"Docstatus\":0,\"Territory\":\"United States\",\"DnRequired\":0,\"ModifiedBy\":\"admin@my.erpnext.com\",\"SoRequired\":0,\"CustomerName\":\"Generic Test Customer\",\"CustomerType\":\"Company\",\"NamingSeries\":\"CUST-.YYYY.-\",\"CustomerGroup\":\"Individual\",\"ExemptFromSalesTax\":0,\"DefaultCommissionRate\":0}";
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void DeserializeCustomerTest()
        {
            // Arrange

            // {
            //     "Idx": 0,
            //     "Name": "Generic Test Customer",
            //     "Owner": "admin@my.erpnext.com",
            //     "Creation": "2022-09-12 14:46:12.845619",
            //     "Disabled": 0,
            //     "IsFrozen": 0,
            //     "Language": "en-US",
            //     "Modified": "2022-09-12 14:46:12.845619",
            //     "Docstatus": 0,
            //     "Territory": "United States",
            //     "DnRequired": 0,
            //     "ModifiedBy": "admin@my.erpnext.com",
            //     "SoRequired": 0,
            //     "CustomerName": "Generic Test Customer",
            //     "CustomerType": "Company",
            //     "NamingSeries": "CUST-.YYYY.-",
            //     "CustomerGroup": "Individual",
            //     "ExemptFromSalesTax": 0,
            //     "IsInternalCustomer": 0,
            //     "DefaultCommissionRate": 0
            // }
            var json = "{\"Idx\":0,\"Name\":\"Generic Test Customer\",\"Owner\":\"admin@my.erpnext.com\",\"Creation\":\"2022-09-12 14:46:12.845619\",\"Disabled\":0,\"IsFrozen\":0,\"Language\":\"en-US\",\"Modified\":\"2022-09-12 14:46:12.845619\",\"Docstatus\":0,\"Territory\":\"United States\",\"DnRequired\":0,\"ModifiedBy\":\"admin@my.erpnext.com\",\"SoRequired\":0,\"CustomerName\":\"Generic Test Customer\",\"CustomerType\":\"Company\",\"NamingSeries\":\"CUST-.YYYY.-\",\"CustomerGroup\":\"Individual\",\"ExemptFromSalesTax\":0,\"IsInternalCustomer\":0,\"DefaultCommissionRate\":0}\r\n";

            // Act

            var customer = ERPNextObjectBase.Deserialize<ERP_Selling_Customer>(json)!;

            // Assert 

            var actualDateTime = customer.Creation;
            var expectedDateTimeLocal = DateTime.Parse("2022-09-12T14:46:12.8456190Z"); //local by default
            var expectedDateTimeOffsetLocal = new DateTimeOffset(expectedDateTimeLocal);
            var expectedDateTimeUtc = expectedDateTimeLocal.ToUniversalTime();
            var expectedDateTimeOffsetUtc = new DateTimeOffset(expectedDateTimeUtc);
            
            //
            // DateTimeOffset rocks!
            //
            Assert.Equal(expectedDateTimeOffsetLocal, expectedDateTimeOffsetUtc);

            //
            // DateTime sucks...
            //
            Assert.NotEqual(expectedDateTimeLocal.Ticks, expectedDateTimeUtc.Ticks);
            Assert.False(expectedDateTimeLocal == expectedDateTimeUtc);
            Assert.Equal(expectedDateTimeUtc, actualDateTime);
            Assert.NotEqual(expectedDateTimeLocal, actualDateTime);
            Assert.True(expectedDateTimeUtc == actualDateTime);
            Assert.False(expectedDateTimeLocal == actualDateTime);


            Assert.Equal("Generic Test Customer", customer.Name);
            Assert.Equal("admin@my.erpnext.com", customer.Owner);
            //Assert.Equal(DateTime.Parse("2022-09-12T14:46:12.8456190Z"), customer.Creation);
            Assert.Equal(0, customer.Disabled);
            Assert.Equal(0, customer.IsFrozen);
            Assert.Equal("en-US", customer.Language);
            Assert.Equal(DateTime.Parse("2022-09-12T14:46:12.8456190Z").ToUniversalTime(), customer.Modified);
            Assert.Equal(0, customer.Docstatus);
            Assert.Equal("United States", customer.Territory);
            Assert.Equal(0, customer.DnRequired);
            Assert.Equal("admin@my.erpnext.com", customer.ModifiedBy);
            Assert.Equal(0, customer.SoRequired);
            Assert.Equal("Generic Test Customer", customer.CustomerName);
            Assert.Equal("Company", customer.CustomerType);
            Assert.Equal("CUST-.YYYY.-", customer.NamingSeries);
            Assert.Equal("Individual", customer.CustomerGroup);
            Assert.Equal(0, customer.ExemptFromSalesTax);
            Assert.Equal(0, customer.IsInternalCustomer);
            Assert.Equal(0, customer.DefaultCommissionRate);


        }



    }
}
