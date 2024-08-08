#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class LoyaltyPointExpirationList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<LoyaltyPointExpiration> LoyaltyPointExpirations { get; private set; }

        internal LoyaltyPointExpirationList()
        {
            this.LoyaltyPointExpirations = new List<LoyaltyPointExpiration>();
        }

        public override string ToString()
        {
            return string.Format("LoyaltyPointExpirationList(Total={0})", this.Total);
        }
    }
}
#endif
