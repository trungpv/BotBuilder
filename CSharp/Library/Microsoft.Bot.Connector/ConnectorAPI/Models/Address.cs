// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// An object relating to a particular point in a conversation
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address(string activityId = default(string), ChannelAccount user = default(ChannelAccount), ChannelAccount bot = default(ChannelAccount), ConversationAccount conversation = default(ConversationAccount), string channelId = default(string), string serviceUrl = default(string), string locale = default(string))
        {
            ActivityId = activityId;
            User = user;
            Bot = bot;
            Conversation = conversation;
            ChannelId = channelId;
            ServiceUrl = serviceUrl;
            Locale = locale;
        }

        /// <summary>
        /// (Optional) ID of the activity to refer to
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

        /// <summary>
        /// (Optional) User participating in this conversation
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public ChannelAccount User { get; set; }

        /// <summary>
        /// Bot participating in this conversation
        /// </summary>
        [JsonProperty(PropertyName = "bot")]
        public ChannelAccount Bot { get; set; }

        /// <summary>
        /// Conversation reference
        /// </summary>
        [JsonProperty(PropertyName = "conversation")]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty(PropertyName = "channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Service endpoint where operations concerning the referenced
        /// conversation may be performed
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// The language code for the conversation
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
