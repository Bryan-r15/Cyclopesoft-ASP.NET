﻿using Cyclopesoft.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class InvoiceDto : BaseDto
    {
        public string Serie { get; set; }
        public string RNC { get; set; }
        public DateTime Expiration_Date { get; set; }
        public string Payment_Type { get; set; }
        public int Client_Id { get; set; }
        public int User_Id { get; set; }
        public int Subtotal { get; set; }
        public int Taxes { get; set; }
        public int Total { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
    }
}
