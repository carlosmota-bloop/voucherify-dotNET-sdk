#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class LoyaltyPointExpirationBucket : ApiObject
    {
        [JsonProperty(PropertyName = "total_points")]
        public int TotalPoints { get; set; }

        public LoyaltyPointExpirationBucket() {
            
        }

        public override string ToString()
        {
            return string.Format("LoyaltyPointExpirationBucket(TotalPoints={0})", 
                this.TotalPoints);
        }
    }
}
#endif