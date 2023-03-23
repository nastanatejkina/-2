internal class Fraction
{
    private int v1;
    private int v2;

    public Fraction(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal object IPart()
    {
        throw new NotImplementedException();
    }
}