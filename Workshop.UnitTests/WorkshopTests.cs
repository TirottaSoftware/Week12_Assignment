using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshop_Management;
using System;
using System.Collections.Generic;
using Workshop_Management.Exceptions;

namespace Workshop.UnitTests
{
    [TestClass]
    public class WorkshopTests
    {
        [TestMethod]
        public void AddParticipantToOnlineWorkshop()
        {
            var workshop = new OnlineWorkshop("test", "testDescription", 10, "https://testurl.com");
            Person person = new Student("Cristian", "Tirotta", 449204);
            workshop.AddParticipant(person);

            CollectionAssert.Contains(workshop.GetParticipants(), person);
        }

        [TestMethod]
        public void AddParticipantToInBuildingWorkshop()
        {
            var workshop = new InBuildingWorkshop("test", "testDescription", 10, "Whateverstraat, 42", 21);
            Person person = new Student("Cristian", "Tirotta", 449204);
            workshop.AddParticipant(person);

            CollectionAssert.Contains(workshop.GetParticipants(), person);
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopArgumentException),
    "Cristian Tirotta is already in the workshop")]
        public void AddAlreadyExistingParticipant()
        {
            var workshop = new InBuildingWorkshop("test", "testDescription", 10, "Whateverstraat, 42", 21);
            Person person = new Student("Cristian", "Tirotta", 449204);
            workshop.AddParticipant(person);
            workshop.AddParticipant(person);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopArgumentException),
    "Workshop is full")]
        public void AddToUnavailableWorkshop()
        {
            var workshop = new InBuildingWorkshop("test", "testDescription", 1, "Whateverstraat, 42", 21);
            Person student = new Student("Cristian", "Tirotta", 449204);
            Person teacher = new Teacher("Mark", "Zuckerberg", 123940);
            workshop.AddParticipant(student);
            workshop.AddParticipant(teacher);

            Assert.Fail();
        }

        [TestMethod]
        public void RemoveParticipant()
        {
            var workshop = new InBuildingWorkshop("test", "testDescription", 10, "Whateverstraat, 42", 21);
            Person person = new Student("Cristian", "Tirotta", 449204);
            workshop.AddParticipant(person);

            workshop.RemoveParticipant(person);

            CollectionAssert.DoesNotContain(workshop.GetParticipants(), person);
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopArgumentException),
    "person not found.")]
        public void RemoveParticipant_Throws_Exception()
        {
            var workshop = new InBuildingWorkshop("test", "testDescription", 10, "Whateverstraat, 42", 21);
            Person person = new Student("Cristian", "Tirotta", 449204);
            workshop.RemoveParticipant(person);

            Assert.Fail();
        }
    }

}
