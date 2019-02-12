using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Security.Role.PutPrivileges
{
	public class PutPrivilegesUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await PUT("/_xpack/security/privilege")
			.Fluent(c => c.PutPrivileges())
			.Request(c => c.PutPrivileges(new PutPrivilegesRequest()))
			.FluentAsync(c => c.PutPrivilegesAsync())
			.RequestAsync(c => c.PutPrivilegesAsync(new PutPrivilegesRequest()));
	}
}
