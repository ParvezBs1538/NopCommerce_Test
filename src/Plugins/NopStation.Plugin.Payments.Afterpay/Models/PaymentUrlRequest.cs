﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace NopStation.Plugin.Payments.Afterpay.Models
{
    public class PaymentUrlRequest
    {
        [JsonProperty("amount")]
        public PaymentAfterpayModel PaymentTotalAmount { get; set; }

        [JsonProperty("consumer")]
        public Consumer Consumer { get; set; }

        [JsonProperty("billing")]
        public AfterpayAddress Billing { get; set; }

        [JsonProperty("shipping")]
        public AfterpayAddress Shipping { get; set; }

        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }

        [JsonProperty("taxAmount")]
        public PaymentAfterpayModel TaxAmount { get; set; }

        [JsonProperty("shippingAmount")]
        public PaymentAfterpayModel ShippingAmount { get; set; }

        [JsonProperty("courier")]
        public Courier Courier { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("discounts")]
        public List<Discount> Discounts { get; set; }

        [JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }
    }
}
