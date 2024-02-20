using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_BSA
{
    [Serializable()]
    public class clConnection
    {
        public string CallID = "", //check
            Device = "", 
            OtherParty = "", //check
            OtherPartyCallID = "", //check
            Extension = "", //check
            TransferVDN = "", 
            HoldingDevice = "", //check
            ActiveDevice = "",
            HoldingCallID = "", //check
            ActiveCallID = "";

        public int ConnectionState;

        public enum States
        {
            Established,
            Initiating,
            Alerting,
            Held,
            Originated,
            AlertingOtherParty,
            Failed
        }

        public override string ToString()
        {
            return ConnectionState + "";
        }
    }
}