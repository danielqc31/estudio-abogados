using Dqc.Domain.Entities.Auditing;

namespace EstudioAbogados.Domain
{
    public class Abogado : FullAuditableEntity
    {
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Nombres { get; set; }
        public string NroDocumento { get; set; }
        public string CodColegioAB { get; set; }
    }
}
