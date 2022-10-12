﻿using MediatR;
using ShopWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Customer.GetAll
{
    public class GetAllCustomersQuery : IRequest<IList<CustomerCommon>>
    {
    }
}