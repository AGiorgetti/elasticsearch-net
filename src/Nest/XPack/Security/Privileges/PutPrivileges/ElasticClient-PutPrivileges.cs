using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public partial interface IElasticClient
	{
		IPutPrivilegesResponse PutPrivileges(Func<PutPrivilegesDescriptor, IPutPrivilegesRequest> selector = null);

		IPutPrivilegesResponse PutPrivileges(IPutPrivilegesRequest request);

		Task<IPutPrivilegesResponse> PutPrivilegesAsync(Func<PutPrivilegesDescriptor, IPutPrivilegesRequest> selector = null,
			CancellationToken cancellationToken = default(CancellationToken)
		);

		Task<IPutPrivilegesResponse> PutPrivilegesAsync(IPutPrivilegesRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}

	public partial class ElasticClient
	{
		public IPutPrivilegesResponse PutPrivileges(Func<PutPrivilegesDescriptor, IPutPrivilegesRequest> selector = null) =>
			PutPrivileges(selector.InvokeOrDefault(new PutPrivilegesDescriptor()));

		public IPutPrivilegesResponse PutPrivileges(IPutPrivilegesRequest request) =>
			Dispatcher.Dispatch<IPutPrivilegesRequest, PutPrivilegesRequestParameters, PutPrivilegesResponse>(
				request,
				LowLevelDispatch.XpackSecurityPutPrivilegesDispatch<PutPrivilegesResponse>
			);

		public Task<IPutPrivilegesResponse> PutPrivilegesAsync(Func<PutPrivilegesDescriptor, IPutPrivilegesRequest> selector = null,
			CancellationToken cancellationToken = default(CancellationToken)
		) =>
			PutPrivilegesAsync(selector.InvokeOrDefault(new PutPrivilegesDescriptor()), cancellationToken);

		public Task<IPutPrivilegesResponse> PutPrivilegesAsync(IPutPrivilegesRequest request, CancellationToken cancellationToken = default(CancellationToken)) =>
			Dispatcher.DispatchAsync<IPutPrivilegesRequest, PutPrivilegesRequestParameters, PutPrivilegesResponse, IPutPrivilegesResponse>(
				request,
				cancellationToken,
				LowLevelDispatch.XpackSecurityPutPrivilegesDispatchAsync<PutPrivilegesResponse>
			);
	}
}
