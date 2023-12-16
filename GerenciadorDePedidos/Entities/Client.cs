using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDePedidos.Entities
{
	public class Client
	{
		public string Name { get; set; }
		public string? Email { get; set; }
		public DateTime BirthDate { get; set; }
		
		public Client(string name, DateTime birthDate)
		{
			Name = name;
			BirthDate = birthDate;
		}
		
		public Client(string name, string email, DateTime birthDate)
		{
			Name = name;
			Email = email;
			BirthDate = birthDate;
		}
	}
}