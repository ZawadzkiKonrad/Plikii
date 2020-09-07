using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Pliki.Domain.Common
{
   public class BaseEntity: AuditableModel
    {
        public int Id { get; set; }
    }
}
