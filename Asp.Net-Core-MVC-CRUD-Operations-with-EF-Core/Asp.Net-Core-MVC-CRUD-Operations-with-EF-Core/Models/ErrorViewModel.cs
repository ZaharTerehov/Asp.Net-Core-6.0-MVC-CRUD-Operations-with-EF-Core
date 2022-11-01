using System;

namespace Asp.Net_Core_MVC_CRUD_Operations_with_EF_Core.Models
{
	public class ErrorViewModel
	{
		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
