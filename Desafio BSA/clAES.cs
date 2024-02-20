using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using AvayaCTClass;

namespace Desafio_BSA
{
    public class clAES : IAES
    {
        private MainClass mAES = new MainClass(true);

        public enum AgentCode
        {
            Login = MainClass.enuAgentMode.amLogIn,
            Logout = MainClass.enuAgentMode.amLogOut,
            Pause = MainClass.enuAgentMode.amNotReady,
            Ready = MainClass.enuAgentMode.amReady
        }

        #region Events

        public event EHOpenStream OpenStreamConf;

        private void MAES_OpenStreamConf()
        {
            OpenStreamConf.Invoke();
        }
        
        public event EHMakeCallConf MakeCallConf;

        private void MAES_MakeCallConf(int InvokeID, int CallID, string Device)
        {
            MakeCallConf.Invoke(InvokeID, CallID, Device);
        }
        
        public event EHAgentState AgentState;

        private void MAES_AgentStateConf(int InvokeID)
        {
            AgentState.Invoke(InvokeID);
        }
        
        public event EHDelivered Delivered;

        private void MAES_Delivered(int CallID, string Alerting, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, string TrunkGroup, string TrunkMember, string UCID, string Queue)
        {
            Delivered.Invoke(CallID, Alerting, Called, Calling, Cause, ConnectionDevice, LastRedirectionDevice, UUI, TrunkGroup, TrunkMember, UCID, Queue);
        }
        
        public event EHEstablished Established;

        private void MAES_Established(int CallID, string Answering, string Called, string Calling, int Cause, string ConnectionDevice, string LastRedirectionDevice, string UUI, int Reason, string UCID, string TrunkGroup, string TrunkMember)
        {
            Established.Invoke(CallID, Answering, Called, Calling, Cause, ConnectionDevice, LastRedirectionDevice, UUI, Reason, UCID, TrunkGroup, TrunkMember);
        }
        
        public event EHCallCleared CallCleared;

        private void MAES_CallCleared(int CallID, string Device, int Cause, int Reason)
        {
            CallCleared.Invoke(CallID, Device, Cause, Reason);
        }
        
        public event EHAnswerCallConf AnswerCallConf;

        private void MAES_AnswerCallConf(int InvokeID)
        {
            AnswerCallConf.Invoke(InvokeID);
        }
        
        public event EHConsultationCallConf ConsultationCallConf;

        private void MAES_ConsultationCallConf(int value1, int CallID, string value2)
        {
            ConsultationCallConf.Invoke(CallID);
        }
        
        public event EHTransferCallConf TransferCallConf;

        private void MAES_TransferCallConf(int InvokeID, int CallID, string Device)
        {
            TransferCallConf.Invoke(InvokeID, CallID, Device);
        }
        
        public event EHRetrieved Retrieved;

        private void MAES_Retrieved(int CallID, string Device, string RetrievedDevice, int Cause)
        {
            Retrieved.Invoke(CallID, Device, RetrievedDevice, Cause);
        }

        public event EHHeld Held;

        private void MAES_Held(int CallID, string Device, string HoldingDevice, int Cause)
        {
            Held.Invoke(CallID, Device, HoldingDevice, Cause);
        }
        
        public event EHAlternateCallConf AlternateCallConf;

        private void MAES_AlternateCallConf(int InvokeID)
        {
            AlternateCallConf.Invoke(InvokeID);
        }
        
        public event EHMonitorConf MonitorConf;

        private void MAES_MonitorConf(int InvokeID, int MonitorCrossrefID)
        {
            MonitorConf.Invoke(InvokeID, MonitorCrossrefID);
        }
        
        public event EHConnectionCleared ConnectionCleared;

        private void MAES_ConnectionCleared(int CallID, string RealeasingDevice, string Device, int Cause)
        {
            ConnectionCleared.Invoke(CallID, RealeasingDevice, Device, Cause);
        }
        
        public event EHConferenceComplete ConferenceCompleteConf;

        private void MAES_ConferenceCompleteConf(int InvokeID, int CallID, string Device)
        {
            ConferenceCompleteConf.Invoke(InvokeID, CallID, Device);
        }

        #endregion

        #region Failures
        
        public event EHOpenStreamFailure OpenStreamFailure;

        private void MAES_OpenStreamFailure(int InvokeID, int ReturnCode)
        {
            OpenStreamFailure.Invoke(InvokeID, ReturnCode);
        }
        
        public event EHUniversalFailure UniversalFailure;

        private void MAES_UniversalFailure(int InvokeID, int ErrCode)
        {
            UniversalFailure.Invoke(InvokeID, ErrCode);
        }

        #endregion

        #region Methods

        public void Init(string ConnectionString, string User, string Password)
        {
            OpenStream(ConnectionString, User, Password, "Desafio BSA");

            mAES.OpenStreamConf += MAES_OpenStreamConf;

            mAES.MakeCallConf += MAES_MakeCallConf;

            mAES.SetAgentStateConf += MAES_AgentStateConf;

            mAES.OpenStreamFailure += MAES_OpenStreamFailure;

            mAES.UniversalFailure += MAES_UniversalFailure;

            mAES.Delivered += MAES_Delivered;

            mAES.Established += MAES_Established;

            mAES.CallCleared += MAES_CallCleared;

            mAES.AnswerCallConf += MAES_AnswerCallConf;

            mAES.ConsultationCallConf += MAES_ConsultationCallConf;

            mAES.TransferCallConf += MAES_TransferCallConf;

            mAES.Retrieved += MAES_Retrieved;

            mAES.Held += MAES_Held;

            mAES.AlternateCallConf += MAES_AlternateCallConf;

            mAES.MonitorConf += MAES_MonitorConf;

            mAES.ConnectionCleared += MAES_ConnectionCleared;

            mAES.ConferenceCallConf += MAES_ConferenceCompleteConf;
        }

        public void OpenStream(string ConnectionString, string User, string Password, string AppName)
        {
            mAES.OpenStream(ConnectionString, User, Password, AppName);
        }

        public void MonitorDevice(string Device)
        {
            mAES.MonitorDevice(Device);
        }

        public void MakeCall(string CallingDevice, string CalledDevice)
        {
            mAES.MakeCall(CallingDevice, CalledDevice, "");
        }

        public void AnswerCall(int CallID, string Device)
        {
            mAES.AnswerCall(CallID, Device, 0);
        }

        public void ClearCall(int CallID, string Extension)
        {
            mAES.ClearCall(CallID, Extension, 0);
        }

        public void TransferInit(int CallID, string CallingDevice, string CalledDevice)
        {
            mAES.ConsultationCall(CallID, CallingDevice, 0, CalledDevice, "");
        }

        public void TransferCall(int HeldCallID, string HeldDevice, int ActiveCallID)
        {
            mAES.TransferCall(HeldCallID, HeldDevice, 0, ActiveCallID, HeldDevice, 0);
        }

        public void TransferCancel(int CallID, string Extension, string ConsultationDevice, int ConsultationCallID)
        {
            mAES.ClearConnection(ConsultationCallID, ConsultationDevice, 0);
            mAES.RetrieveCall(CallID, Extension, 0);
        }

        public void AlternateCall(int ActiveCallID, string ActiveDevice, int HeldCallID, string HeldDevice)
        {
            mAES.AlternateCall(ActiveCallID, ActiveDevice, 0, HeldCallID, HeldDevice, 0);
        }

        public void ConferenceComplete(int HeldCallID, string HeldDevice, int ActiveCallID)
        {
            mAES.ConferenceCall(HeldCallID, HeldDevice, 0, ActiveCallID, HeldDevice, 0);
        }

        public void CloseStream()
        {
            mAES.CloseStream();
        }

        public void SetAgentState(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password)
        {
            mAES.SetAgentState(Extension, (int)Mode, Login, Group, Password);
        }

        public void SetAgentStateExt(string Extension, MainClass.enuAgentMode Mode, string Login, string Group, string Password, MainClass.enuReadyAgentMode rdyMode, int ReasonCode, bool EnablePending)
        {
            mAES.SetAgentStateExt(Extension, (int)Mode, Login, Group, Password, rdyMode, ReasonCode, EnablePending);
        }

        // Eventos
        //event void OpenStreamFailure(int invokeid, int retcode);
        //event void QueryAcdSplitConf(int invokeid, int availagents, int loggedagents, int callsinqueue);
        //event void QueryAgentLoginConf(int invokeid, int newinvokeid);
        //event void QueryAgentLoginResp(int invokeid, ArrayList* agents);
        //event void QueryDeviceNameConf(int invokeid, String* device, String* devicename);
        //event void QueryDeviceInfoConf(int invokeid, String* device, String* login);
        //event void AgentLoggedOn(int monitorcrossrefid, String* login, String* device, String* group, String* password);
        //event void AgentLoggedOff(int monitorcrossrefid, String* login, String* device, String* group);
        //event void SysStatReqConf(int invokeid, int systemstatus);
        //event void MakePredictiveCallConf(int invokeid, int callid, String* device);
        //event void CallCleared(int callid, String* device, int cause, int reason);
        //event void ConnectionCleared(int callid, String* releasingdevice, String* device, int cause);
        //event void Delivered(int callid, String* alerting, String* called, String* calling, int cause, String* connectiondevice, String* lastredirectiondevice, String* uui, String* trunkgroup, String* trunkmember, String* ucid, String* queue);
        //event void MonitorEnded(int invokeid, int cause);
        //event void Established(int callid, String* answering, String* called, String* calling, int cause, String* connectiondevice, String* lastredirectiondevice, String* uui, int reason, String* ucid, String* trunkgroup, String* trunkmember);
        //event void NetworkReached(int callid, String* device, String* called, String* trunk, int cause);
        //event void ClearCallConf(int invokeid);
        //event void ClearConnectionConf(int invokeid);
        //event void AnswerCallConf(int invokeid);
        //event void RouteRequestExt(int invokeid, int routeRegisterReqID, int routingCrossRefID, int callid, String* device, String* calling, String* digits, String* uui);
        //event void RouteRegisterAbort(int routeRegisterReqID);
        //event void RouteUsed(int routeRegisterReqID, int routingCrossRefID, String* routeUsed, String* calling);
        //event void RouteEndEvent(int routeRegisterReqID, int routingCrossRefID, int errorValue);
        //event void ReRouteRequest(int routeRegisterReqID, int routingCrossRefID);
        //event void RouteRegisterReqConf(int invokeid, int routeRegisterReqID);
        //event void Queued(int callid, String* queue, String* called, String* calling, int numbqueued, int cause, String* connectiondevice, String* lastredirectiondevice);
        //event void Transferred(int pricallid, String* pridevice, int seccallid, String* secdevice, String* transfDevice, int cause, String* uui, ArrayList* transferredDevicesList);
        //event void Failed(int callid, String* device, int cause);
        //event void MakeCallConf(int invokeid, int callid, String* device);
        //event void Held(int callid, String* device, String* holdingDevice, int cause);
        //event void Retrieved(int callid, String* device, String* retrievedDevice, int cause);
        //event void SnapshotCallConf(int invokeid, int count, ArrayList* deviceInfoList);
        //event void SnapshotDeviceConf(int invokeid, int count, ArrayList* callInfoList);
        //event void HoldCallConf(int invokeid);
        //event void RetrieveCallConf(int invokeid);
        //event void AlternateCallConf(int invokeid);
        //event void TransferCallConf(int invokeid, int callid, String* device);
        //event void ConferenceCallConf(int invokeid, int callid, String* device);
        //event void SetAgentStateConf(int invokeid);
        //event void Conferenced(int pricallid, String* pridevice, int seccallid, String* secdevice, String* transfDevice, int cause, ArrayList* transferredDevicesList);

        #endregion
    }
}