public static class Extensions 
{
    public static float AddPercentage(this float baseValue, float percentageValue) => (baseValue * percentageValue)/100;
    public static float RemovePercentage(this float currentValue, float percentageValue)
    {
        float originalValue = currentValue/(1 + percentageValue)/100;

        return currentValue - originalValue;
    }
}
