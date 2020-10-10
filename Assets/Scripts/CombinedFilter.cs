
public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Modulo3Filter.moduloInput(CubeFilter.cubes(xs));
    }
}

