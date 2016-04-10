using System;

public class FacebookMeResult : FacebookBaseDTO
{
	public class FacebookMeHometown : FacebookBaseDTO
	{
		public string id;

		public string name;
	}

	public class FacebookMeLocation : FacebookBaseDTO
	{
		public string id;

		public string name;
	}

	public string id;

	public string name;

	public string first_name;

	public string last_name;

	public string link;

	public string username;

	public FacebookMeResult.FacebookMeHometown hometown;

	public FacebookMeResult.FacebookMeLocation location;

	public string gender;

	public string email;

	public int timezone;

	public string locale;

	public bool verified;

	public DateTime updated_time;
}
