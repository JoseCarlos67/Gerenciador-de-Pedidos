using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDePedidos.Entities.Enums;

namespace GerenciadorDePedidos.Entities
{
	public class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }
		public List<OrderItem> Items = new List<OrderItem>();
		
		public Order(DateTime moment, OrderStatus status)
		{
			Moment = moment;
			Status = status;
		}
		
		public void AddItem(OrderItem orderItem)
		{
			Items.Add(orderItem);
		}
		
		public void RemoveItem(OrderItem orderItem)
		{
			Items.Remove(orderItem);
		}
		
		public double Total()
		{
			double sum = 0;
			foreach(OrderItem item in Items)
			{
				sum += item.SubTotal();
			}
			return sum;
		}
	}
}