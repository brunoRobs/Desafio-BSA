using AvayaCTClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Interface;

namespace Desafio_BSA
{
    public class clCTI
    {
        private clAES mAES = new clAES();

        public string ConnectionString,
            User, Password,
            Extension, Destination,
            AgentID, AgentPassword;

        private int mLastInvokeId;

        private MainClass.enuAgentMode mLastAgentMode = MainClass.enuAgentMode.amLogOut;

        private Form mParentForm;

        public Form ParentForm
        {
            get { return mParentForm; }
            set
            {
                mParentForm = value;
            }
        }

        public List<clConnection> Connections = new List<clConnection>();

        public IAES MAES { get; set; }

        public clCTI()
        {
            MAES = mAES;
        }

        public clCTI(IAES mock)
        {
            MAES = mock;

            MAES.OpenStreamConf += MAES_OpenStreamConf;

            MAES.MakeCallConf += MAES_MakeCallConf;

            MAES.AgentState += MAES_AgentStateConf;

            MAES.OpenStreamFailure += MAES_OpenStreamFailure;

            MAES.UniversalFailure += MAES_UniversalFailure;

            MAES.Delivered += MAES_Delivered;

            MAES.Established += MAES_Established;

            MAES.CallCleared += MAES_CallCleared;

            MAES.AnswerCallConf += MAES_AnswerCallConf;

            MAES.ConsultationCallConf += MAES_ConsultationCallConf;

            MAES.TransferCallConf += MAES_TransferCallConf;

            MAES.Retrieved += MAES_Retrieved;

            MAES.Held += MAES_Held;

            MAES.AlternateCallConf += MAES_AlternateCallConf;

            MAES.MonitorConf += MAES_MonitorConf;

            MAES.ConnectionCleared += MAES_ConnectionCleared;

            MAES.ConferenceCompleteConf += MAES_ConferenceCompleteConf;
        }

        #region Events

        public delegate void EventHandler();

        public event EventHandler InitOk, Disconnect, MonitorOk, CallOk,

            LoginOk, Logout, PauseOk, ReadyOk,

            ConnectedCall, DisconnectedCall,

            InitFailed, Failure;

        private void MAES_OpenStreamConf()
        {
            if(mParentForm != null) mParentForm.Invoke(InitOk);
        }

        public delegate void EHMonitorConf(int InvokeID, int MonitorCrossrefID);

        private void MAES_MonitorConf(int InvokeID, int MonitorCrossrefID)
        {
            if(mParentForm != null) mParentForm.Invoke(MonitorOk);
        }

        private delegate void EHAgentState(int InvokeID);

        private void MAES_AgentStateConf(int InvokeID)
        {
            switch (mLastAgentMode)
            {
                case MainClass.enuAgentMode.amLogIn:
                    if(mParentForm != null) mParentForm.Invoke(LoginOk);
                    break;
                case MainClass.enuAgentMode.amReady:
                    if(mParentForm != null) mParentForm.Invoke(ReadyOk);
                    break;
                case MainClass.enuAgentMode.amNotReady:
                    if(mParentForm != null) mParentForm.Invoke(PauseOk);
                    break;
                case MainClass.enuAgentMode.amLogOut:
                    if(mParentForm != null) mParentForm.Invoke(Logout);
                    break;
            }
        }

        public delegate void EHMakeCallConf(int InvokeID, int CallID, string Device);

        private void MAES_MakeCallConf(int InvokeID, int CallID, string Device)
        {
            if(mParentForm != null) mParentForm.Invoke(CallOk);
        }

        public delegate void EHDelivered(string Calling);
        public event EHDelivered Delivered;

        private void MAES_Delivered(int CallID, string Alerting, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, string TrunkGroup, string TrunkMember, string UCID, string Queue)
        {
            if (!Connections.Contains(Connections.Find(x => x.CallID.Equals(CallID.ToString()))))
            {
                clConnection connection = new clConnection();

                connection.CallID = CallID.ToString();
                if (Connections.Count == 0 && !Called.Equals(this.Extension))
                {
                    string otherParty = Called;
                    Called = Calling;
                    Calling = otherParty;
                }
                connection.Device = Called;
                connection.OtherParty = Calling;
                connection.ConnectionState = (int)clConnection.States.Alerting;
                Connections.Add(connection);

                if (!Connections.First().CallID.Equals(CallID.ToString()))
                {
                    Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held).OtherPartyCallID = CallID.ToString();
                    connection.OtherPartyCallID = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held).CallID;
                }
            }

            if(Connections.Count == 1 && !Connections.First().Device.Equals(Extension))
            {
                string otherParty = Connections.First().Device;
                Connections.First().Device = Extension;
                Connections.First().OtherParty = otherParty;
            }

            if(mParentForm != null) mParentForm.Invoke(Delivered, Calling);
        }

        private void MAES_Established(int CallID, string Answering, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, int Reason, string UCID, string TrunkGroup, string TrunkMember)
        {
            Connections.Find(x => x.CallID.Equals(CallID.ToString())).ConnectionState = (int)clConnection.States.Established;

            if(mParentForm != null) mParentForm.Invoke(ConnectedCall);
        }

        public delegate void EHCallCleared(int CallID, string Device, int Cause, int Reason);
        public event EHCallCleared CallCleared;

        private void MAES_CallCleared(int CallID, string Device, int Cause, int Reason)
        {
            CallCleared.Invoke(CallID, Device, Cause, Reason);

            if(mParentForm != null) mParentForm.Invoke(DisconnectedCall);
        }

        public delegate void EHAnswerCallConf(int InvokeID);
        public event EHAnswerCallConf AnswerCallConf;

        private void MAES_AnswerCallConf(int InvokeID)
        {
            if(mParentForm != null) mParentForm.Invoke(AnswerCallConf, InvokeID);
        }

        public delegate void EHConsultationCallConf(int CallID);
        public event EHConsultationCallConf ConsultationCallConf;

        private void MAES_ConsultationCallConf(int CallID)
        {
            if(mParentForm != null) mParentForm.Invoke(ConsultationCallConf, CallID);
        }

        public delegate void EHTransferCallConf(int InvokeID, int CallID, string Device);
        public event EHTransferCallConf TransferCallConf;

        private void MAES_TransferCallConf(int InvokeID, int CallID, string Device)
        {
            Connections.Clear();

            if(mParentForm != null) mParentForm.Invoke(TransferCallConf, InvokeID, CallID, Device);
        }

        public delegate void EHRetrieved(int CallID, string Device, string RetrievedDevice, int Cause);
        public event EHRetrieved Retrieved;

        private void MAES_Retrieved(int CallID, string Device, string RetrievedDevice, int Cause)
        {
            Connections.Find(x => x.CallID.Equals(CallID.ToString())).ConnectionState = (int)clConnection.States.Established;

            if(mParentForm != null) mParentForm.Invoke(Retrieved, CallID, Device, RetrievedDevice, Cause);
        }

        public delegate void EHHeld(int CallID, string Device, string HoldingDevice, int Cause);
        public event EHHeld Held;

        //HELD => CONSULTATION => DELIVERED => => ESTABLISHED
        private void MAES_Held(int CallID, string Device, string HoldingDevice, int Cause)
        {
            clConnection OldConnection = Connections.Find(x => x.CallID.Equals(CallID.ToString()));

            OldConnection.ConnectionState = (int)clConnection.States.Held;

            OldConnection.HoldingCallID = CallID.ToString();

            OldConnection.HoldingDevice = Device;

            if(mParentForm != null) mParentForm.Invoke(Held, CallID, Device, HoldingDevice, Cause);
        }

        public delegate void EHAlternateCallConf(int InvokeID);
        public event EHAlternateCallConf AlternateCallConf;

        private void MAES_AlternateCallConf(int InvokeID)
        {
            if(mParentForm != null) mParentForm.Invoke(AlternateCallConf, InvokeID);
        }

        public delegate void EHConnectionCleared(int CallID, string RealeasingDevice, string Device, int Cause);
        public event EHConnectionCleared ConnectionCleared;

        private void MAES_ConnectionCleared(int CallID, string RealeasingDevice, string Device, int Cause)
        {
            Connections.Remove(Connections.Find(x => x.CallID == CallID.ToString()));

            if (Connections.Contains(Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held)))
            {
                clConnection AlertingConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held);
                AlertingConnection.ConnectionState = (int)clConnection.States.Alerting;
                if (!AlertingConnection.Device.Equals(Extension))
                {
                    string otherParty = AlertingConnection.Device;
                    AlertingConnection.Device = Extension;
                    AlertingConnection.OtherParty = otherParty;
                }
                AlertingConnection.HoldingCallID = "";
                AlertingConnection.OtherPartyCallID = "";
                AlertingConnection.TransferVDN = "";
            }

            if(mParentForm != null) mParentForm.Invoke(ConnectionCleared, CallID, RealeasingDevice, Device, Cause);
        }

        public delegate void EHConferenceComplete(string Device);

        public event EHConferenceComplete ConferenceCompleteConf;

        private void MAES_ConferenceCompleteConf(int InvokeID, int CallID, string Device)
        {
            Connections.Remove(Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held));
            if(mParentForm != null) mParentForm.Invoke(ConferenceCompleteConf, Device);
        }

        #endregion

        #region Failures

        public delegate void EHOpenStreamFailure(int InvokeID, int ReturnCode);

        private void MAES_OpenStreamFailure(int InvokeID, int ReturnCode)
        {
            if(mParentForm != null) mParentForm.Invoke(InitFailed);
        }

        public delegate void EHUniversalFailure(int InvokeID, int ErrCode);

        private void MAES_UniversalFailure(int InvokeID, int ErrCode)
        {
            if(mParentForm != null) mParentForm.Invoke(Failure);
        }

        #endregion

        #region Methods

        public void Init(string ConnectionString = "", string User = "", string Password = "", string Extension = "")
        {
            this.ConnectionString = ConnectionString;

            this.User = User;

            this.Password = Password;

            MAES.Init(ConnectionString, User, Password);

            this.Extension = Extension;

            MAES.OpenStreamConf += MAES_OpenStreamConf;

            MAES.MakeCallConf += MAES_MakeCallConf;

            MAES.AgentState += MAES_AgentStateConf;

            MAES.OpenStreamFailure += MAES_OpenStreamFailure;

            MAES.UniversalFailure += MAES_UniversalFailure;

            MAES.Delivered += MAES_Delivered;

            MAES.Established += MAES_Established;

            MAES.CallCleared += MAES_CallCleared;

            MAES.AnswerCallConf += MAES_AnswerCallConf;

            MAES.ConsultationCallConf += MAES_ConsultationCallConf;

            MAES.TransferCallConf += MAES_TransferCallConf;

            MAES.Retrieved += MAES_Retrieved;

            MAES.Held += MAES_Held;

            MAES.AlternateCallConf += MAES_AlternateCallConf;

            MAES.MonitorConf += MAES_MonitorConf;

            MAES.ConnectionCleared += MAES_ConnectionCleared;

            MAES.ConferenceCompleteConf += MAES_ConferenceCompleteConf;
        }

        public void Monitor()
        {
            try
            {
                MAES.MonitorDevice(this.Extension);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void MakeCall(string Destination)
        {
            try
            {
                this.Destination = Destination;

                MAES.MakeCall(this.Extension, Destination);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void AnswerCall()
        {
            try
            {
                clConnection AlertingConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Alerting);

                MAES.AnswerCall(Int32.Parse(AlertingConnection.CallID), AlertingConnection.Device);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }
        
        public void CallClear()
        {
            try
            {
                clConnection EstablishedConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Established);

                MAES.ClearCall(Int32.Parse(EstablishedConnection.CallID), EstablishedConnection.Device);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void TransferInit(string Destination)
        {
            try
            {
                clConnection EstablishedConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Established);

                EstablishedConnection.TransferVDN = Destination;

                MAES.TransferInit(Int32.Parse(EstablishedConnection.CallID), EstablishedConnection.Device, EstablishedConnection.TransferVDN);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void TransferCall()
        {
            try
            {
                clConnection HeldConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held);

                MAES.TransferCall(Int32.Parse(HeldConnection.CallID), HeldConnection.Device, Int32.Parse(HeldConnection.OtherPartyCallID));
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void TransferCancel()
        {
            try
            {
                clConnection EstablishedConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Established);

                clConnection HeldConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held);

                MAES.TransferCancel(Int32.Parse(HeldConnection.CallID), HeldConnection.Device, HeldConnection.TransferVDN, Int32.Parse(EstablishedConnection.CallID));
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void AlternateCall()
        {
            try
            {
                clConnection HeldConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Held);

                MAES.AlternateCall(Int32.Parse(HeldConnection.OtherPartyCallID), HeldConnection.HoldingDevice, Int32.Parse(HeldConnection.CallID), HeldConnection.HoldingDevice);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void ConferenceComplete()
        {
            try
            {
                clConnection EstablishedConnection = Connections.Find(x => x.ConnectionState == (int)clConnection.States.Established);

                if (EstablishedConnection.HoldingDevice.Equals(""))
                {
                    MAES.ConferenceComplete(Int32.Parse(EstablishedConnection.OtherPartyCallID), EstablishedConnection.OtherParty, Int32.Parse(EstablishedConnection.CallID));
                }
                else
                {
                    MAES.ConferenceComplete(Int32.Parse(EstablishedConnection.OtherPartyCallID), EstablishedConnection.HoldingDevice, Int32.Parse(EstablishedConnection.CallID));
                }
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void End()
        {
            try
            {
                if (mLastAgentMode != MainClass.enuAgentMode.amLogOut)
                {
                    LogOut();
                    if(mParentForm != null) mParentForm.Invoke(Logout);
                }

                MAES.CloseStream();

                if(mParentForm != null) mParentForm.Invoke(Disconnect);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void LogIn(string AgentID, string AgentPassword)
        {
            try
            {
                this.AgentID = AgentID;
                this.AgentPassword = AgentPassword;
                MAES.SetAgentState(this.Extension, mLastAgentMode = MainClass.enuAgentMode.amLogIn, AgentID, "", AgentPassword);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void LogOut()
        {
            try
            {
                MAES.SetAgentState(this.Extension, mLastAgentMode = MainClass.enuAgentMode.amLogOut, AgentID, "", AgentPassword);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void Ready()
        {
            try
            {
                MAES.SetAgentState(this.Extension, mLastAgentMode = MainClass.enuAgentMode.amReady, AgentID, "", Password);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        public void Pause(string ReasonCode)
        {
            try
            {
                MAES.SetAgentStateExt(this.Extension, mLastAgentMode = MainClass.enuAgentMode.amNotReady, AgentID, "", Password, AvayaCTClass.MainClass.enuReadyAgentMode.ManualIn, Int32.Parse(ReasonCode.Substring(0, 1)), true);
            }
            catch
            {
                if(mParentForm != null) mParentForm.Invoke(Failure);
            }
        }

        #endregion
    }
}