﻿//------------------------------------------------------------------------------
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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Permeability.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PermeabilityTestsBase
    {
        protected abstract double HenriesPerMeterInOneHenryPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HenriesPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void HenryPerMeterToPermeabilityUnits()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            AssertEx.EqualTolerance(HenriesPerMeterInOneHenryPerMeter, henrypermeter.HenriesPerMeter, HenriesPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Permeability.From(1, PermeabilityUnit.HenryPerMeter).HenriesPerMeter, HenriesPerMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var henrypermeter = Permeability.FromHenriesPerMeter(1);
            AssertEx.EqualTolerance(HenriesPerMeterInOneHenryPerMeter, henrypermeter.As(PermeabilityUnit.HenryPerMeter), HenriesPerMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var henrypermeter = Permeability.FromHenriesPerMeter(1);

            var henrypermeterQuantity = henrypermeter.ToUnit(PermeabilityUnit.HenryPerMeter);
            AssertEx.EqualTolerance(HenriesPerMeterInOneHenryPerMeter, (double)henrypermeterQuantity.Value, HenriesPerMeterTolerance);
            Assert.Equal(PermeabilityUnit.HenryPerMeter, henrypermeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            AssertEx.EqualTolerance(1, Permeability.FromHenriesPerMeter(henrypermeter.HenriesPerMeter).HenriesPerMeter, HenriesPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Permeability v = Permeability.FromHenriesPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permeability.FromHenriesPerMeter(3)-v).HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permeability.FromHenriesPerMeter(10)/5).HenriesPerMeter, HenriesPerMeterTolerance);
            AssertEx.EqualTolerance(2, Permeability.FromHenriesPerMeter(10)/Permeability.FromHenriesPerMeter(5), HenriesPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Permeability oneHenryPerMeter = Permeability.FromHenriesPerMeter(1);
            Permeability twoHenriesPerMeter = Permeability.FromHenriesPerMeter(2);

            Assert.True(oneHenryPerMeter < twoHenriesPerMeter);
            Assert.True(oneHenryPerMeter <= twoHenriesPerMeter);
            Assert.True(twoHenriesPerMeter > oneHenryPerMeter);
            Assert.True(twoHenriesPerMeter >= oneHenryPerMeter);

            Assert.False(oneHenryPerMeter > twoHenriesPerMeter);
            Assert.False(oneHenryPerMeter >= twoHenriesPerMeter);
            Assert.False(twoHenriesPerMeter < oneHenryPerMeter);
            Assert.False(twoHenriesPerMeter <= oneHenryPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            Assert.Equal(0, henrypermeter.CompareTo(henrypermeter));
            Assert.True(henrypermeter.CompareTo(Permeability.Zero) > 0);
            Assert.True(Permeability.Zero.CompareTo(henrypermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            Assert.Throws<ArgumentException>(() => henrypermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => henrypermeter.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Permeability v = Permeability.FromHenriesPerMeter(1);
            Assert.True(v.Equals(Permeability.FromHenriesPerMeter(1), HenriesPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Permeability.Zero, HenriesPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            Assert.False(henrypermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Permeability henrypermeter = Permeability.FromHenriesPerMeter(1);
            Assert.False(henrypermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PermeabilityUnit.Undefined, Permeability.Units);
        }

    }
}
