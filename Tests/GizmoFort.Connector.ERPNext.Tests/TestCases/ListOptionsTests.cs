using GizmoFort.Connector.ERPNext.PublicTypes;
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
using GizmoFort.Connector.ERPNext.PublicInterfaces;

namespace GizmoFort.Connector.ERPNext.Tests.TestCases
{
    public class ListOptionsTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ListOptionsTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        private string Serialize(FetchListOption? listOption)
        {
            if (listOption is null)
                return String.Empty;

            var parameterList = new List<string>();

            var included_fields = listOption.IncludedFields ?? new List<string>();
            if (included_fields.Any())
            {
                string filter_val = JsonSerializer.Serialize(included_fields.ToList());
                parameterList.Add($"fields={filter_val}");
            }

            var filters = listOption.Filters ?? new List<ERPFilter>();
            if (filters.Any())
            {
                string filter_val = JsonSerializer.Serialize(filters.Select(ERPNextClient.ToFilterObject).ToList());
                parameterList.Add($"filters={filter_val}");
            }

            if (listOption.PageSize > 0)
            {
                parameterList.Add($"limit_page_length={listOption.PageSize}");
            }

            if (listOption.PageStartIndex > 0)
            {
                parameterList.Add($"limit_start={listOption.PageStartIndex}");
            }

            return String.Join("&", parameterList);

        }

        [Fact]
        public void NonArrayTest()
        {
            // Arrange

            var listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Selling_Customer, "name", OperatorFilter.Equals, "test name"));
            listOption.IncludedFields.AddRange(new string[] { "name", "website" });

            // Act

            var actual = Serialize(listOption);

            // Assert 

            var expected = "fields=[\"name\",\"website\"]&filters=[[\"Customer\",\"name\",\"=\",\"test name\"]]";
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ArrayTest()
        {
            // Arrange

            var listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Selling_Customer, "name", OperatorFilter.In, "test name 1", "test name 2"));
            listOption.IncludedFields.AddRange(new string[] { "name", "website" });

            // Act

            var actual = Serialize(listOption);

            // Assert 

            var expected = "fields=[\"name\",\"website\"]&filters=[[\"Customer\",\"name\",\"in\",[\"test name 1\",\"test name 2\"]]]";
            Assert.Equal(expected, actual);

        }


    }
}
