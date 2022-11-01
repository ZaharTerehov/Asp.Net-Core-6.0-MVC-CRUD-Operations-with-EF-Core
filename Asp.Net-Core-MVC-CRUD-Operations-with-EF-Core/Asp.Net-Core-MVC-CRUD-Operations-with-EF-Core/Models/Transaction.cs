using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Asp.Net_Core_MVC_CRUD_Operations_with_EF_Core.Models 
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }

		[Column(TypeName ="nvarchar(12)")]
		public string AccountNumber { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string BeneficiaryName { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string BankName { get; set; }

		[Column(TypeName = "nvarchar(11)")]
		public string SWIFT { get; set; }

		public int Amount { get; set; }

		public DataTime Data { get; set; }
	}
}
