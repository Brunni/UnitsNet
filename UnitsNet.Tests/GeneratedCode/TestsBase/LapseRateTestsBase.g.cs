//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LapseRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LapseRateTestsBase : QuantityTestsBase
    {
        protected abstract double DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelciusPerKilometerTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LapseRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LapseRateUnit.DegreeCelsiusPerKilometer, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LapseRate(double.PositiveInfinity, LapseRateUnit.DegreeCelsiusPerKilometer));
            Assert.Throws<ArgumentException>(() => new LapseRate(double.NegativeInfinity, LapseRateUnit.DegreeCelsiusPerKilometer));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LapseRate(double.NaN, LapseRateUnit.DegreeCelsiusPerKilometer));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LapseRate(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new LapseRate(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (LapseRate) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void LapseRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LapseRate(1, LapseRateUnit.DegreeCelsiusPerKilometer);

            QuantityInfo<LapseRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LapseRate.Zero, quantityInfo.Zero);
            Assert.Equal("LapseRate", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<LapseRateUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DegreeCelsiusPerKilometerToLapseRateUnits()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, degreecelsiusperkilometer.DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LapseRate.From(1, LapseRateUnit.DegreeCelsiusPerKilometer);
            AssertEx.EqualTolerance(1, quantity00.DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            Assert.Equal(LapseRateUnit.DegreeCelsiusPerKilometer, quantity00.Unit);

        }

        [Fact]
        public void FromDegreesCelciusPerKilometer_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.NegativeInfinity));
        }

        [Fact]
        public void FromDegreesCelciusPerKilometer_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LapseRate.FromDegreesCelciusPerKilometer(double.NaN));
        }

        [Fact]
        public void As()
        {
            var degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, degreecelsiusperkilometer.As(LapseRateUnit.DegreeCelsiusPerKilometer), DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new LapseRate(value: 1, unit: LapseRate.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);

            var degreecelsiusperkilometerQuantity = degreecelsiusperkilometer.ToUnit(LapseRateUnit.DegreeCelsiusPerKilometer);
            AssertEx.EqualTolerance(DegreesCelciusPerKilometerInOneDegreeCelsiusPerKilometer, (double)degreecelsiusperkilometerQuantity.Value, DegreesCelciusPerKilometerTolerance);
            Assert.Equal(LapseRateUnit.DegreeCelsiusPerKilometer, degreecelsiusperkilometerQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = LapseRate.FromDegreesCelciusPerKilometer(1).ToBaseUnit();
            Assert.Equal(LapseRate.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(1, LapseRate.FromDegreesCelciusPerKilometer(degreecelsiusperkilometer.DegreesCelciusPerKilometer).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LapseRate v = LapseRate.FromDegreesCelciusPerKilometer(1);
            AssertEx.EqualTolerance(-1, -v.DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerKilometer(3)-v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (v + v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(10, (v*10).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(10, (10*v).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerKilometer(10)/5).DegreesCelciusPerKilometer, DegreesCelciusPerKilometerTolerance);
            AssertEx.EqualTolerance(2, LapseRate.FromDegreesCelciusPerKilometer(10)/LapseRate.FromDegreesCelciusPerKilometer(5), DegreesCelciusPerKilometerTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LapseRate oneDegreeCelsiusPerKilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            LapseRate twoDegreesCelciusPerKilometer = LapseRate.FromDegreesCelciusPerKilometer(2);

            Assert.True(oneDegreeCelsiusPerKilometer < twoDegreesCelciusPerKilometer);
            Assert.True(oneDegreeCelsiusPerKilometer <= twoDegreesCelciusPerKilometer);
            Assert.True(twoDegreesCelciusPerKilometer > oneDegreeCelsiusPerKilometer);
            Assert.True(twoDegreesCelciusPerKilometer >= oneDegreeCelsiusPerKilometer);

            Assert.False(oneDegreeCelsiusPerKilometer > twoDegreesCelciusPerKilometer);
            Assert.False(oneDegreeCelsiusPerKilometer >= twoDegreesCelciusPerKilometer);
            Assert.False(twoDegreesCelciusPerKilometer < oneDegreeCelsiusPerKilometer);
            Assert.False(twoDegreesCelciusPerKilometer <= oneDegreeCelsiusPerKilometer);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Equal(0, degreecelsiusperkilometer.CompareTo(degreecelsiusperkilometer));
            Assert.True(degreecelsiusperkilometer.CompareTo(LapseRate.Zero) > 0);
            Assert.True(LapseRate.Zero.CompareTo(degreecelsiusperkilometer) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Throws<ArgumentException>(() => degreecelsiusperkilometer.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Throws<ArgumentNullException>(() => degreecelsiusperkilometer.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.True(v.Equals(LapseRate.FromDegreesCelciusPerKilometer(1), DegreesCelciusPerKilometerTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LapseRate.Zero, DegreesCelciusPerKilometerTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(LapseRate.FromDegreesCelciusPerKilometer(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.False(degreecelsiusperkilometer.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LapseRate degreecelsiusperkilometer = LapseRate.FromDegreesCelciusPerKilometer(1);
            Assert.False(degreecelsiusperkilometer.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LapseRateUnit)).Cast<LapseRateUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LapseRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 ∆°C/km", new LapseRate(1, LapseRateUnit.DegreeCelsiusPerKilometer).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 ∆°C/km", new LapseRate(1, LapseRateUnit.DegreeCelsiusPerKilometer).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s1"));
                Assert.Equal("0.12 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s2"));
                Assert.Equal("0.123 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s3"));
                Assert.Equal("0.1235 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s1", culture));
            Assert.Equal("0.12 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s2", culture));
            Assert.Equal("0.123 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s3", culture));
            Assert.Equal("0.1235 ∆°C/km", new LapseRate(0.123456, LapseRateUnit.DegreeCelsiusPerKilometer).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(LapseRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LapseRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(LapseRate.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(LapseRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(1.0);
            Assert.Equal(new {LapseRate.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = LapseRate.FromDegreesCelciusPerKilometer(value);
            Assert.Equal(LapseRate.FromDegreesCelciusPerKilometer(-value), -quantity);
        }
    }
}
