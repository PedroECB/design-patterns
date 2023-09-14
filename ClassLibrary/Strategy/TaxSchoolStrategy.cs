class TaxSchoolStrategy : ITax
{
    // As estratégias concretas implementam diferentes variações de um algoritmo que o contexto usa.
    public decimal Calculate(decimal value)
    {
        return value * 0.2M;
    }
}