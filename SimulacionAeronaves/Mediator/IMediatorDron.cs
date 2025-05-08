namespace SimulacionAeronaves.Mediator
{
    public interface IMediatorDron
    {
        void ReasignarRuta(IDron dron);
        void ConfirmarPatrullaje(IDron dron);
        void ReubicarVigilancia(IDron dron);
    }
}

