﻿#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CustomerUpdate
    {
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        private CustomerUpdate()
        {
            this.Metadata = new Metadata();
        }

        public static CustomerUpdate FromEmpty()
        {
            return new CustomerUpdate();
        }

        public static CustomerUpdate FromCustomer(DataModel.Customer customer)
        {
            Metadata metadata = null;

            if (customer.Metadata != null)
            {
                metadata = new Metadata();

                foreach (var key in customer.Metadata.Keys)
                {
                    metadata.Add(key, customer.Metadata[key]);
                }
            }

            return new CustomerUpdate()
            {
                Name = customer.Name,
                Email = customer.Email,
                Description = customer.Description,
                Metadata = metadata
            };
        }

        public CustomerUpdate WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public CustomerUpdate WithEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public CustomerUpdate WithDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public CustomerUpdate WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif