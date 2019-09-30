using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool AddOrderInfo(string customerName,string iteamName,int orderQuantity,double totalPrice)
        {
            return _orderRepository.AddOrderInfo(customerName,iteamName,orderQuantity,totalPrice);
        }
    }
}
