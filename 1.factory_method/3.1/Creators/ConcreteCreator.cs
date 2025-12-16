using _3._1.Products;
using _3._1.Products;

namespace _3._1.Creators;

public class ConcreteCreator : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProduct();
    }
}