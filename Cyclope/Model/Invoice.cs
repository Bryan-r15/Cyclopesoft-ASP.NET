﻿using System;
using System.ComponentModel;

namespace Cyclopesoft.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public string RNC { get; set; }
        public DateTime Creation_Date { get; set; }
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