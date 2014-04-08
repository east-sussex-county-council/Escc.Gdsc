using System;

namespace EsccWebTeam.Gdsc
{
	/// <summary>
	/// Indicates whether contact information is for work or personal purposes
	/// </summary>
    [Serializable]
    public enum ContactUsage
	{
		/// <summary>
		/// Usage of the contact number is not known
		/// </summary>
		NotSpecified,

		/// <summary>
		/// Indicates contact information for work purposes
		/// </summary>
		Work,
		
		/// <summary>
		/// Indicates contact information for personal purposes
		/// </summary>
		Home
	}
}
