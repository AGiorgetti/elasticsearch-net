using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{
	/// <summary>
	/// Adds or updates application privileges.
	/// </summary>
	public partial interface IPutPrivilegesRequest { }

	/// <inheritdoc cref="IPutPrivilegesRequest" />
	public partial class PutPrivilegesRequest
	{
	}

	/// <inheritdoc cref="IPutPrivilegesRequest" />
	[DescriptorFor("XpackSecurityPutPrivileges")]
	public partial class PutPrivilegesDescriptor
	{
	}
}
