#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class LoyaltyPointExpiration : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "voucher_id")]
        public string VoucherId { get; set; }

        [JsonProperty(PropertyName = "campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty(PropertyName = "bucket")]
        public LoyaltyPointExpirationBucket Bucket { get; set; }

        public LoyaltyPointExpiration() {
            
        }

        public override string ToString()
        {
            return string.Format("LoyaltyPointExpiration(Id={0})", 
                this.Id);
        }
    }
}
#endif