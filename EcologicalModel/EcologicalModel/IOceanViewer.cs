namespace EcologicalModel
{
    interface IOceanViewer
    {
        void PrintOcean();
        void InputOceanParameters(ref int width, ref int height, ref int predatorCount, ref int preyCount,
           ref int obstacleCount, ref int iteretionsCount);
        bool CellsCountOutput(int iteretionIndex);
        void NotifyGameOver();
    }
}
