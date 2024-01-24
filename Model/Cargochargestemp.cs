﻿using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Cargochargestemp
{
    public int ChargeId { get; set; }

    public int CargoId { get; set; }

    public int? PayingPartyId { get; set; }

    public int ChargeItemId { get; set; }

    public string? IncomeExpense { get; set; }

    public string? ChargeDescription { get; set; }

    public string? ApplyPer { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public int? CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExRate { get; set; }

    public int? TaxRateId { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalNonTaxableAmount { get; set; }

    public int? SalesQuoteChargeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public int? LineNumber { get; set; }

    public int? CostSheetId { get; set; }
}
