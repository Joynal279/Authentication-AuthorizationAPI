using System;
namespace Authentication_AuthorizationAPI.Models
{
	public class User
	{
		public string UserName { get; set; } = string.Empty;
		public string PasswordHash { get; set; } = string.Empty;
	}
}

