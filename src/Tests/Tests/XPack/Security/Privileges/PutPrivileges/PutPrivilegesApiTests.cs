using System;
using System.Collections.Generic;
using Elastic.Managed.Ephemeral;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Core.Extensions;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework;
using Tests.Framework.Integration;
using static Nest.Infer;

namespace Tests.XPack.Security.Role.PutPrivileges
{
	[SkipVersion("<6.4.0", "Privileges API added in 6.4.0")]
	public class PutPrivilegesApiTests : ApiIntegrationTestBase<XPackCluster, IPutPrivilegesResponse, IPutPrivilegesRequest, PutPrivilegesDescriptor, PutPrivilegesRequest>
	{
		public PutPrivilegesApiTests(XPackCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;

		protected override object ExpectJson => null;

		protected override int ExpectStatusCode => 200;

		protected override Func<PutPrivilegesDescriptor, IPutPrivilegesRequest> Fluent => d => d;

		protected override HttpMethod HttpMethod => HttpMethod.PUT;

		protected override PutPrivilegesRequest Initializer => new PutPrivilegesRequest();

		protected override bool SupportsDeserialization => false;

		protected override string UrlPath => "/_xpack/security/privilege";

		protected override LazyResponses ClientUsage() => Calls(
			(client, f) => client.PutPrivileges(f),
			(client, f) => client.PutPrivilegesAsync(f),
			(client, r) => client.PutPrivileges(r),
			(client, r) => client.PutPrivilegesAsync(r)
		);

		protected override PutPrivilegesDescriptor NewDescriptor() => new PutPrivilegesDescriptor();

		protected override void ExpectResponse(IPutPrivilegesResponse response)
		{
			response.ShouldBeValid();
		}
	}
}
