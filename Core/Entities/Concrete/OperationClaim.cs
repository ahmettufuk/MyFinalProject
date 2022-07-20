using entities.absract;

namespace Core.Entities.Concrete;

public partial class OperationClaim : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}