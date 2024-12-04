using CSharpEgitimKampiMY301.DataAccessLayer.Abstract;
using CSharpEgitimKampiMY301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiMY301.BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
    }
}
