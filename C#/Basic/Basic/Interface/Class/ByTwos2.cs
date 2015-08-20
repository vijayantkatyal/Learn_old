class ByTwos2:Interface2
{
    int val;

    public ByTwos2()
    {
        val = 0;
    }

    // Get or Set value using a property.
    public int Next
    {
        get
        {
            val += 2;
            return val;
        }

        set
        {
            val = value;
        }
    }

    // Get a value using an index.
    public int this[int index]
    {
        get
        {
            val = 0;
            for (int i = 0; i < index; i++)
                val += 2;
            return val;
        }
    }

}