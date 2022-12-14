using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCCRUDEFCore.Models
{
	public class TransactionDbContext : DbContext
	{
		public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
		{

		}

		public DbSet<Transaction> Transaction { get; set; }
	}
}
