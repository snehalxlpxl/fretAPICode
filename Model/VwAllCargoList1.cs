﻿using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAllCargoList1
{
    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public int? ShipperId { get; set; }

    public int? ConsigneeId { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? ContainerNo { get; set; }

    public int? Invoiceno { get; set; }

    public string? OceanLine { get; set; }

    public string? Vessel { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? Cycle { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? CreatedBys { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBys { get; set; }

    public DateTime? DateModified { get; set; }

    public int? OfficeId { get; set; }

    public string? WebJob { get; set; }

    public string? CustomerName { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public string? BookingNumber { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? InvoiceNumber { get; set; }
}
