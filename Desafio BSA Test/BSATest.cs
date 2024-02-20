using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_BSA;
using Interface;
using NUnit.Framework;
using Moq;

namespace Desafio_BSA_Test
{
    [TestFixture]
    public class BSATest
    {
        Moq.Mock<IAES> mock;
        clCTI CTI;

        //Arrange
        [SetUp]
        public void SetUp()
        {
            mock = new Moq.Mock<IAES>();
            CTI = new clCTI(mock.Object);
            CTI.Extension = "40402";
        }

        [Test]
        public void MakeCall()
        {
            mock.Setup(m => m.MakeCall(It.IsAny<string>(), It.IsAny<string>())).Callback(
                (string extension, string destination) =>
                {
                    mock.Raise(m => m.Delivered += null, 1, "", extension, destination, 0, "", "", "", "", "", "", "");
                    mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");
                }
           );

            //Act
            CTI.MakeCall("40410");

            //Assert
            Assert.AreEqual((int)clConnection.States.Established, CTI.Connections.First().ConnectionState);
        }

        [Test]
        public void AnswerCall()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40410", 0, "", "", "", "", "", "", "");

            mock.Setup(m => m.AnswerCall(It.IsAny<int>(), It.IsAny<string>())).Callback(
                (int callID, string device)
                 =>
                {
                    mock.Raise(m => m.Established += null, callID, "", "", "", -1, "", "", "", 0, "", "", "");
                }
            );

            //Act
            CTI.AnswerCall();

            //Assert
            Assert.AreEqual((int)clConnection.States.Established, CTI.Connections.First().ConnectionState);
        }

        [Test]
        public void DropCall()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40410", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.ClearCall(It.IsAny<int>(), It.IsAny<string>())).Callback(
                (int callID, string device)
                 =>
                {
                    mock.Raise(m => m.ConnectionCleared += null, callID, "", "", -1);
                }
            );

            //Act
            CTI.CallClear();

            //Assert
            Assert.AreEqual(0, CTI.Connections.Count);
        }

        [Test]
        public void TransferInit()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40410", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.TransferInit(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>())).Callback(
                (int callID, string device, string destination)
                 =>
                {
                    mock.Raise(m => m.Held += null, 1, device, "", -1);
                    mock.Raise(m => m.Delivered += null, 2, "", destination, device, 0, "", "", "", "", "", "", "");
                    mock.Raise(m => m.Established += null, 2, "", "", "", 0, "", "", "", "", "", "", "");
                }
            );

            //Act
            CTI.TransferInit("40408");

            //Assert
            Assert.AreEqual((int)clConnection.States.Held, CTI.Connections.First().ConnectionState);
        }

        [Test]
        public void TransferCancel()
        {

            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40408", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");
            mock.Raise(m => m.Held += null, 1, "40402", "", -1);
            mock.Raise(m => m.Delivered += null, 2, "", "40410", "40402", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 2, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.TransferCancel(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())).Callback(
                (int callID, string extension, string consultationDevice, int consultationCallID)
                 =>
                {
                    mock.Raise(m => m.ConnectionCleared += null, consultationCallID, "", "", -1);
                    mock.Raise(m => m.Established += null, callID, "", "", "", -1, "", "", "", 0, "", "", "");
                }
            );

            //Act
            CTI.TransferCancel();

            //Assert
            Assert.AreEqual(1, CTI.Connections.Count);
        }
        
        [Test]
        public void TransferComplete()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40408", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");
            mock.Raise(m => m.Held += null, 1, "40402", "", -1);
            mock.Raise(m => m.Delivered += null, 2, "", "40410", "40402", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 2, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.TransferCall(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>())).Callback(
                (int heldCallID, string heldDevice, int activeCallID)
                 =>
                {
                    mock.Raise(m => m.TransferCallConf += null, 0, activeCallID, "0");
                }
            );

            //Act
            CTI.TransferCall();

            //Assert
            Assert.AreEqual(0, CTI.Connections.Count);
        }

        [Test]
        public void AlternateCall()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40408", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");
            mock.Raise(m => m.Held += null, 1, "40402", "", -1);
            mock.Raise(m => m.Delivered += null, 2, "", "40410", "40402", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 2, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.AlternateCall(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>())).Callback(
                (int activeCallID, string activeDevice, int heldCallID, string heldDevice)
                 =>
                {
                    //var established = CTI.Connections.Find(c => c.ConnectionState == (int)clConnection.States.Established);
                    //var held = CTI.Connections.Find(c => c.ConnectionState == (int)clConnection.States.Held);
                    mock.Raise(m => m.Held += null, activeCallID, activeDevice, "", -1);
                    mock.Raise(m => m.Retrieved += null, heldCallID, "", "", -1);
                }
            );

            //Act
            for (int i = 1; i <= 2; i++)
            {
                CTI.AlternateCall();
            }

            //Assert
            Assert.AreEqual((int)clConnection.States.Established, CTI.Connections.Last().ConnectionState);
        }

        [Test]
        public void ConferenceComplete()
        {
            mock.Raise(m => m.Delivered += null, 1, "", "40402", "40408", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 1, "", "", "", -1, "", "", "", 0, "", "", "");
            mock.Raise(m => m.Held += null, 1, "40402", "", -1);
            mock.Raise(m => m.Delivered += null, 2, "", "40410", "40402", 0, "", "", "", "", "", "", "");
            mock.Raise(m => m.Established += null, 2, "", "", "", -1, "", "", "", 0, "", "", "");

            mock.Setup(m => m.ConferenceComplete(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>())).Callback(
                (int heldCallID, string heldDevice, int activeCallID)
                 =>
                {
                    mock.Raise(m => m.ConferenceCompleteConf += null, 0, activeCallID, "");
                }
            );

            //Act
            CTI.ConferenceComplete();

            //Assert
            Assert.AreEqual(1, CTI.Connections.Count);
        }
    }
}