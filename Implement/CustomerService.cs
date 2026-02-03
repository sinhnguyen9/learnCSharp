using MyApp.Interface;

namespace MyApp.Implement
{
    public class CustomerService
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;
        public CustomerService(ILogger logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void GetInfo()
        {
            _logger.Log("Log day");
            _repository.SqlRepository();
        }
    }
}
