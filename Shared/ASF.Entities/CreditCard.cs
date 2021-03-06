﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;


namespace ASF.Entities
{
    /// <summary>
    /// Represents a row of entity data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class CreditCard : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Id")]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Empresa")]
        public string Name { get; set; }

        [DataMember]
        [DisplayName("Numero Tarjeta")]
        public int number { get; set; }

        [DataMember]
        [DisplayName("Mes Vencimiento")]
        public int endMonth { get; set; }

        [DataMember]
        [DisplayName("Año Vencimiento")]
        public int endYear { get; set; }

        [DataMember]
        [DisplayName("Codigo Verificador")]
        public int codVer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Created By")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Changed On")]
        public DateTime ChangedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Changed By")]
        public int? ChangedBy { get; set; }

        /// <summary>
        /// Displays the values of the properties for debugging purposes.
        /// </summary>

    }
}

