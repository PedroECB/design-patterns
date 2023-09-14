interface ITax
{
    // A interface Strategy é comum à todas as estratégias concretas. Ela declara um método que o contexto usa para executar uma estratégia.
    decimal Calculate(decimal value);
}