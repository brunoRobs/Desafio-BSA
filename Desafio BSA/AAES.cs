using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvayaCTClass;
using Interface;

namespace AbstractCTI
{
    public abstract class AAES : IAES
    {
        public delegate void EHOpenStream();

        public delegate void EHMakeCallConf(int InvokeID, int CallID, string Device);

        public delegate void EHAgentState(int InvokeID);

        public delegate void EHDelivered(int CallID, string Alerting, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, string TrunkGroup, string TrunkMember, string UCID, string Queue);

        public delegate void EHEstablished(int CallID, string Answering, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, int Reason, string UCID, string TrunkGroup, string TrunkMember);

        public delegate void EHCallCleared(int CallID, string Device, int Cause, int Reason);

        public delegate void EHAnswerCallConf(int InvokeID);

        public delegate void EHConsultationCallConf(int CallID);

        public delegate void EHTransferCallConf(int InvokeID, int CallID, string Device);

        public delegate void EHRetrieved(int CallID, string Device, string RetrievedDevice, int Cause);

        public delegate void EHHeld(int CallID, string Device, string HoldingDevice, int Cause);

        public delegate void EHAlternateCallConf(int InvokeID);

        public delegate void EHMonitorConf(int InvokeID, int MonitorCrossrefID);

        public delegate void EHConnectionCleared(int CallID, string RealeasingDevice, string Device, int Cause);

        public delegate void EHConferenceComplete(int InvokeID, int CallID, string Device);

        public abstract void AlternateCall(int ActiveCallID, string ActiveDevice, int HeldCallID, string HeldDevice);

        public abstract void AnswerCall(int CallID, string Device);

        public abstract void ClearCall(int CallID, string Extension);

        public abstract void CloseStream();

        public abstract void ConferenceComplete(int HeldCallID, string HeldDevice, int ActiveCallID);

        public abstract void Init(string ConnectionString, string User, string Password);

        public abstract void MakeCall(string CallingDevice, string CalledDevice);

        public abstract void MonitorDevice(string Device);

        public abstract void OpenStream(string ConnectionString, string User, string Password, string AppName);

        public abstract void SetAgentState(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password);

        public abstract void SetAgentStateExt(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password, MainClass.enuReadyAgentMode rdyMode, int ReasonCode, bool EnablePending);

        public abstract void TransferCall(int HeldCallID, string HeldDevice, int ActiveCallID);

        public abstract void TransferCancel(int CallID, string Extension, string ConsultationDevice, int ConsultationCallID);

        public abstract void TransferInit(int CallID, string CallingDevice, string CalledDevice);
    }
}