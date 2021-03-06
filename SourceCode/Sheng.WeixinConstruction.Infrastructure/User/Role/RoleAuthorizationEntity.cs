﻿using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    [Table("RoleAuthorization")]
    public class RoleAuthorizationEntity
    {
        public Guid Domain
        {
            get;
            set;
        }

        public Guid Role
        {
            get;
            set;
        }

        public string AuthorizationKey
        {
            get;
            set;
        }
    }
}
