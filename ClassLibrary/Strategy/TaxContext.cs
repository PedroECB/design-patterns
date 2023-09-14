class TaxContext
{
    // O Contexto mantém uma referência para uma das estratégias concretas e se comunica com esse objeto através da interface da estratégia.
    private ITax _taxStrategy;

    public void SetTaxStrategy(ITax calculateTax)
    {
        _taxStrategy = calculateTax;
    }

    public decimal ExecuteStrategy(decimal value)
    {
        return _taxStrategy.Calculate(value);
    }
}