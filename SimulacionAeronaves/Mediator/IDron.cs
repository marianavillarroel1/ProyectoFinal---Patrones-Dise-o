namespace Mediator
{
    public interface IDron
    {
        void Volar();
        void AsignarMediator(IMediatorDron mediator);
        void SolicitarReasignacionRuta();
        void SolicitarConfirmacionPatrullaje();
        void SolicitarReubicacionVigilancia();
        string GetNombre();
    }
}
