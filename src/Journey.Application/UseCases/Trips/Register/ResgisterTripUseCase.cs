using Journey.Communication.Requests;

namespace Journey.Application.UseCases.Trips.Register
{
    public class ResgisterTripUseCase
    {
        public void Execute(RequestRegisterTripJson request) 
        {
            Validate(request);

        }
        private void Validate(RequestRegisterTripJson request) 
        {
            if(string.IsNullOrWhiteSpace(request.Name))
            {
                throw new ArgumentException("Nome não pode ser Vazio!!!");              
            } 
            if(request.StartDate.Date < DateTime.UtcNow.Date)
            {
                throw new ArgumentException("A viagem não pode ser para uma data passada");
            }
            if(request.EndDate.Date < request.StartDate.Date)
            {
                throw new ArgumentException("O termino da viagem não pode ser igual a data de inicio");
            }
        }
    }
}
