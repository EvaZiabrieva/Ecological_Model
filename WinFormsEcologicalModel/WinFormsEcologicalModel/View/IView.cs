namespace WinFormsEcologicalModel
{
    interface IView
    {
        void PrintField(CellData[,] field);
        void NotifySimulationEnd();
    }
}
