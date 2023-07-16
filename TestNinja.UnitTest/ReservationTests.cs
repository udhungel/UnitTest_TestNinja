using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrage
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true }); 
            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            var user = new User();
            //Arrage
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var user = new User();
            //Arrage
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.IsFalse(result);
        }
    }
}
