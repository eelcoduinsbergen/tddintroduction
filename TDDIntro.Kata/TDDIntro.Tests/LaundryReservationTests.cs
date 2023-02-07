using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TDDIntro.Tests
{
    public class LaundryReservationTests
    {
        Mock<IMailService> mailService;
        Mock<IRepository<Reservation>> reservationRepoMock;

        public LaundryReservationTests()            
        {
            mailService = new Mock<IMailService>();
            reservationRepoMock = new Mock<IRepository<Reservation>>();

        }

        [Fact]
        public void Should_Create_Reservation()
        {            
            var sut = new ReservationService(mailService.Object, reservationRepoMock.Object);

            var reservation = sut.CreateReservation(new DateTime(2022, 1, 1), "12345678", "eelco@vxcompany.com");

            reservation.ReservationDate.Should().Be(new DateTime(2022, 1, 1));
            reservation.Email.Should().Be("eelco@vxcompany.com");
            reservation.CellPhone.Should().Be("12345678");
        }
        [Fact]
        public void Should_Send_Confirmation_Mail()
        {            
            var sut = new ReservationService(mailService.Object, reservationRepoMock.Object);

            var reservation = sut.CreateReservation(new DateTime(2022, 1, 1), "12345678", "eelco@vxcompany.com");
            
            mailService.Verify(p => p.SendConfirmation(It.IsAny<Reservation>()), Times.Once);            
        }

        [Fact]
        public void Should_Save_Reservation_To_Database()
        {
            var sut = new ReservationService(mailService.Object, reservationRepoMock.Object);

            var reservation = sut.CreateReservation(new DateTime(2022, 1, 1), "12345678", "eelco@vxcompany.com");
                        
            reservationRepoMock.Verify(p => p.Add(It.IsAny<Reservation>()), Times.Once);
        }
    }

    internal class ReservationService
    {
        private readonly IMailService mailService;
        private readonly IRepository<Reservation> repository;

        public ReservationService(IMailService mailService, IRepository<Reservation> repository)
        {
            this.mailService = mailService;
            this.repository = repository;
        }

        internal Reservation CreateReservation(DateTime reservationDate, string cellPhone, string email)
        {
            var reservation = new Reservation(reservationDate, cellPhone, email);
            repository.Add(reservation);
            mailService.SendConfirmation(reservation);            
            return reservation;
        }
    }

    public interface IMailService
    {
        void SendConfirmation(Reservation reservation);
    }

    public interface IRepository<T>
    {
        void Add(T entity);
    }

    public class Reservation
    {
        public DateTime ReservationDate { get; private set; }
        public string CellPhone { get; }
        public string Email { get; }

        public Reservation(DateTime date, string cellPhone, string email)
        {
            ReservationDate = date;
            CellPhone = cellPhone;
            Email = email;
        }
    }
}
