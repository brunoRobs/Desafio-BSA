using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvayaCTClass;

namespace Interface
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

    public delegate void EHOpenStreamFailure(int InvokeId, int ReturnCode);

    public delegate void EHUniversalFailure(int InvokeId, int ErrCode);

    public interface IAES
    {
        event EHOpenStream OpenStreamConf;

        event EHMakeCallConf MakeCallConf;

        event EHAgentState AgentState;

        event EHDelivered Delivered;

        event EHEstablished Established;

        event EHCallCleared CallCleared;

        event EHAnswerCallConf AnswerCallConf;

        event EHConsultationCallConf ConsultationCallConf;

        event EHTransferCallConf TransferCallConf;

        event EHRetrieved Retrieved;

        event EHHeld Held;

        event EHAlternateCallConf AlternateCallConf;

        event EHMonitorConf MonitorConf;

        event EHConnectionCleared ConnectionCleared;

        event EHConferenceComplete ConferenceCompleteConf;

        event EHOpenStreamFailure OpenStreamFailure;

        event EHUniversalFailure UniversalFailure;

        void OpenStream(string ConnectionString, string User, string Password, string AppName);

        void Init(string ConnectionString, string User, string Password);

        void MonitorDevice(string Device);

        void MakeCall(string CallingDevice, string CalledDevice);

        void AnswerCall(int CallID, string Device);

        void ClearCall(int CallID, string Extension);

        void TransferInit(int CallID, string CallingDevice, string CalledDevice);

        void TransferCall(int HeldCallID, string HeldDevice, int ActiveCallID);

        void TransferCancel(int CallID, string Extension, string ConsultationDevice, int ConsultationCallID);

        void AlternateCall(int ActiveCallID, string ActiveDevice, int HeldCallID, string HeldDevice);

        void ConferenceComplete(int HeldCallID, string HeldDevice, int ActiveCallID);

        void CloseStream();

        void SetAgentState(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password);

        void SetAgentStateExt(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password, MainClass.enuReadyAgentMode rdyMode, int ReasonCode, bool EnablePending);
    }
}