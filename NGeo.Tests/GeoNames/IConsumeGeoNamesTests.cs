﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class ConsumeGeoNamesTests
    {
        [TestMethod]
        public void GeoNames_IConsumeGeoNames_ShouldImplementIDisposable()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Object.ShouldImplement<IDisposable>();
        }

        [TestMethod]
        public void GeoNames_FindNearbyPlaceName_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.FindNearbyPlaceName(It.IsAny<NearbyPlaceNameFinder>()))
                .Returns(new ReadOnlyCollection<Toponym>(new List<Toponym>()));
            var results = contract.Object.FindNearbyPlaceName(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_LookupPostalCode_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.LookupPostalCode(It.IsAny<PostalCodeLookup>()))
                .Returns(new ReadOnlyCollection<PostalCode>(new List<PostalCode>()));
            var results = contract.Object.LookupPostalCode(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_PostalCodeCountryInfo_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.PostalCodeCountryInfo(It.IsAny<string>()))
                .Returns(new ReadOnlyCollection<PostalCodedCountry>(new List<PostalCodedCountry>()));
            var results = contract.Object.PostalCodeCountryInfo(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Get_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.Get(It.IsAny<int>(), It.IsAny<string>()))
                .Returns(new Toponym());
            var result = contract.Object.Get(0, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Children_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.Children(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<ResultStyle>(), It.IsAny<int>()))
                .Returns(new ReadOnlyCollection<Toponym>(new List<Toponym>()));
            var results = contract.Object.Children(0, null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Countries_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.Countries(It.IsAny<string>()))
                .Returns(new ReadOnlyCollection<Country>(new List<Country>()));
            var results = contract.Object.Countries(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumeGeoNames>();
            contract.Setup(m => m.Hierarchy(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<ResultStyle>()))
                .Returns(new Hierarchy());
            var results = contract.Object.Hierarchy(0, null);
            results.ShouldNotBeNull();
        }

    }
}
