using Dqc.Domain.Uow;

namespace Dqc.Application.Services
{
    public abstract class ApplicationService : IApplicationService
    {
        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork == null)
                {
                    throw new DqcException("Must set UnitOfWork before use it.");
                }

                return _unitOfWork;
            }
            set { _unitOfWork = value; }
        }

        protected ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
