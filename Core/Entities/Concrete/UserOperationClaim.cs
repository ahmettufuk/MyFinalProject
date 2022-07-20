using entities.absract;

namespace Core.Entities.Concrete;

public partial class UserOperationClaim : IEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }
}