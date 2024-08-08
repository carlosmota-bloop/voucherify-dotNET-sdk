﻿#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Loyalties : EndpointBase
    {
        public Loyalties(Api api) : base(api)
        {
        }

        public async Task<DataModel.LoyaltyPointExpirationList> GetLoyaltyPointsExpiration(string campaignId, string memberId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("loyalties/{0}/members/{1}/points-expiration", UriBuilderExtension.EnsureEscapedDataString("campaignId", campaignId), UriBuilderExtension.EnsureEscapedDataString("memberId", memberId)));
            return await this.client.DoGetRequest<Voucherify.DataModel.LoyaltyPointExpirationList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif