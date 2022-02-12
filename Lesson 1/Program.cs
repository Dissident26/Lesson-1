NailsHammering hammerTheNails = new NailsHammering();
hammerTheNails.startHammering(3, 6);

struct IntegerRange
{
    public int min, max;
    public IntegerRange(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
}

static class IntegerRangeValidator
{
    public static bool validate (int number, IntegerRange inclusiveRange)
    {
        bool IsNumberValid = number >= inclusiveRange.min && number <= inclusiveRange.max;

        if (!IsNumberValid)
        {
            throw new ArgumentException($"Inavalid argument! Should be in range from {inclusiveRange.min} to {inclusiveRange.max}"); ;
        }

        return IsNumberValid;
    }
} 

class IterateWithSubIterations
{
    private IntegerRange iterationInclusiveRange;
    private IntegerRange subIterationInclusevieRange;
    public IterateWithSubIterations (IntegerRange iterationInclusiveRange, IntegerRange subIterationInclusevieRange)
    {
        this.iterationInclusiveRange = iterationInclusiveRange;
        this.subIterationInclusevieRange = subIterationInclusevieRange;
    }

    public void iterate (int iterations, int subIterations)
    {
        for(int i = iterations; i >= iterationInclusiveRange.min; i--)
        {
            Console.WriteLine("Iteration");

            for(int j = subIterations; j >= subIterationInclusevieRange.min; j--)
            {
                Console.WriteLine("SubIteration");
            }
        }
    }
}

class NailsHammering
{
    static IntegerRange inclusiveNailsAmount = new IntegerRange(1, 10);
    static IntegerRange inclusiveHammerHitsAmount = new IntegerRange(1, 5);

    private IterateWithSubIterations iterator = new IterateWithSubIterations(inclusiveNailsAmount, inclusiveHammerHitsAmount);

    public void startHammering (int nails, int hitsPerNail)
    {
        validateArguments(nails, hitsPerNail);
        iterator.iterate(nails, hitsPerNail);
    }

    private void validateArguments (int nails, int hitsPerNail)
    {
        IntegerRangeValidator.validate(nails, inclusiveNailsAmount);
        IntegerRangeValidator.validate(hitsPerNail, inclusiveNailsAmount);
    }
}