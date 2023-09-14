class TaxContext
{
    // O Contexto mantém uma referência para uma das estratégias concretas e se comunica com esse objeto através da interface da estratégia.
    private ITax TaxStrategy;

    public void SetTaxStrategy(ITax calculateTax)
    {
        TaxStrategy = calculateTax;
    }

    public decimal ExecuteStrategy(decimal value)
    {
        return TaxStrategy.Calculate(value);
    }
}