namespace OceanLogic
{
    public interface IOceanView
    {
        int GetWidth();
        int GetHeight();
        char GetCellView(int i, int j);
    }
}
