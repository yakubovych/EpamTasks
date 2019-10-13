using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW.Net.Tests
{
    public class RectangleTask1Tests
    {
        [TestMethod()]
        public void Perimetеr_5and5_20returned()
        {
            double LeftTopY = 5;
            double LeftTopX = 10;
            double RightBottomY = 10;
            double RightBottomX = 15;

            double expected = 20;

            RectangleTask1 rectangle = new RectangleTask1(LeftTopY, LeftTopX, RightBottomY, RightBottomX);
            double actual = rectangle.Perimetеr();

            Assert.AreEqual(expected, actual);
        }
    }
}