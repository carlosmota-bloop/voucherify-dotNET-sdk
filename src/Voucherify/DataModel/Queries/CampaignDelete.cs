﻿#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class CampaignDelete : Core.DataModel.ForcedOperation
    {
        // Kept for backward comaptibility
    }
}
#endif