#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class LoyaltyCard : ApiObject
    {
        [JsonProperty(PropertyName = "points")]
        public long Points { get; private set; }

        [JsonProperty(PropertyName = "balance")]
        public long Balance { get; private set; }

        public LoyaltyCard() { }
        
        public override string ToString()
        {
            return string.Format("LoyaltyCard(Points={0},Balance={1})", this.Points, this.Balance);
        }
    }
}
#endif