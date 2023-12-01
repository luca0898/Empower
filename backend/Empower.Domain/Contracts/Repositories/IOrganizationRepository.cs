using Empower.Domain.Contracts.Repositories.Shared;
using Empower.Domain.Entities;

namespace Empower.Domain.Contracts.Repositories;

internal interface IOrganizationRepository :
    IGenericReadableRepository<string, Organization>,
    IGenericWritableRepository<string, Organization>
{
    Task<Organization> FindByOrganizationNameAsync(string organizationName, CancellationToken cancellationToken = default);
}
