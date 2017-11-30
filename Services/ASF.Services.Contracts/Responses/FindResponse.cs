//====================================================================================================
// Base code generated with LeatherGoods - ASF.Services.Contracts
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ASF.Entities;


namespace ASF.Services.Contracts
{
    
    [DataContract]
    public class FindResponse
    {
        [DataMember]
        public Category ResultCategory { get; set; }

        [DataMember]
        public Country ResultCountry { get; set; }

        [DataMember]
        public Dealer ResultDealer { get; set; }

        [DataMember]
        public DealerDTO ResultDealerDTO { get; set; }

        [DataMember]
        public Order ResultOrder { get; set; }

        [DataMember]
        public Client ResultClient { get; set; }

        [DataMember]
        public  Product ResultProduct { get; set; }

        [DataMember]
        public Cart ResultCart { get; set; }
    }
}

