namespace WinFormsEcologicalModel
{
    public interface IController
    {
        string StartSimulation(int width, int height, int predatorCount, int preyCount,
            int obstacleCount, int iteretionsCount, int staticSuperPredator);
        void Terminate();
    }
}
