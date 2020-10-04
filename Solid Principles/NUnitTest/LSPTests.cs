using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using NUnit.Framework;
using System.Text;
using LSP;

namespace NUnitTest
{
    public class LSPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SixFor2x3Rectangle()
        {
            var rectangle = new Rectangles(){Height = 2, Width = 3};
            var result = rectangle.Area();
            Assert.AreEqual(6, result);
        }

        [Test]
        public void NineFor3x3Square()
        {
            var squares = new Squares(){Sides = 3};
            var result = squares.Area();
            Assert.AreEqual(9, result);
        }
        [Test]
        public void TwentyFourFor6x4RectangleAnd9For3x3Square()
        {
            var shape = new List<Shape>
            {
                new Squares() {Sides = 3},
                new Rectangles() {Height = 4, Width = 6}
            };

            var areas = new List<int>();
            foreach (var s in shape)
            {
                //if (s.GetType() == typeof(Rectangles))
                //{
                //    areas.Add(((Rectangles)s).Area());
                //}

                //if (s.GetType() == typeof(Squares))
                //{
                //    areas.Add(((Squares)s).Area());
                //}
                //This if else used while Shape class hasn't any abstract Area method
                areas.Add(s.Area());
            }
            Assert.AreEqual(24, areas[1]);
            Assert.AreEqual(9, areas[0]);
        }
    }
}
