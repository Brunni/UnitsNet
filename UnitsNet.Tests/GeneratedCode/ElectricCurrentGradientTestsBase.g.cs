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
    /// Test of ElectricCurrentGradient.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentGradientTestsBase
    {
        protected abstract double AmperesPerSecondInOneAmperePerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void AmperePerSecondToElectricCurrentGradientUnits()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, amperepersecond.AmperesPerSecond, AmperesPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricCurrentGradient.From(1, ElectricCurrentGradientUnit.AmperePerSecond).AmperesPerSecond, AmperesPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, amperepersecond.As(ElectricCurrentGradientUnit.AmperePerSecond), AmperesPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);

            var amperepersecondQuantity = amperepersecond.ToUnit(ElectricCurrentGradientUnit.AmperePerSecond);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, (double)amperepersecondQuantity.Value, AmperesPerSecondTolerance);
            Assert.Equal(ElectricCurrentGradientUnit.AmperePerSecond, amperepersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(1, ElectricCurrentGradient.FromAmperesPerSecond(amperepersecond.AmperesPerSecond).AmperesPerSecond, AmperesPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrentGradient v = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentGradient.FromAmperesPerSecond(3)-v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentGradient.FromAmperesPerSecond(10)/5).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrentGradient.FromAmperesPerSecond(10)/ElectricCurrentGradient.FromAmperesPerSecond(5), AmperesPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrentGradient oneAmperePerSecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            ElectricCurrentGradient twoAmperesPerSecond = ElectricCurrentGradient.FromAmperesPerSecond(2);

            Assert.True(oneAmperePerSecond < twoAmperesPerSecond);
            Assert.True(oneAmperePerSecond <= twoAmperesPerSecond);
            Assert.True(twoAmperesPerSecond > oneAmperePerSecond);
            Assert.True(twoAmperesPerSecond >= oneAmperePerSecond);

            Assert.False(oneAmperePerSecond > twoAmperesPerSecond);
            Assert.False(oneAmperePerSecond >= twoAmperesPerSecond);
            Assert.False(twoAmperesPerSecond < oneAmperePerSecond);
            Assert.False(twoAmperesPerSecond <= oneAmperePerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Equal(0, amperepersecond.CompareTo(amperepersecond));
            Assert.True(amperepersecond.CompareTo(ElectricCurrentGradient.Zero) > 0);
            Assert.True(ElectricCurrentGradient.Zero.CompareTo(amperepersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Throws<ArgumentException>(() => amperepersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => amperepersecond.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricCurrentGradient v = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.True(v.Equals(ElectricCurrentGradient.FromAmperesPerSecond(1), AmperesPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrentGradient.Zero, AmperesPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.False(amperepersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.False(amperepersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentGradientUnit.Undefined, ElectricCurrentGradient.Units);
        }

    }
}
