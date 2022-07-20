namespace WinFormsEcologicalModel
{
    interface IView
    {
        void PrintField(char[,] field);
        void NotifySimulationEnd();
    }
}
