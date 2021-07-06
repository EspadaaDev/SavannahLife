public interface IAnimal
{
    public float Health { get; }    
    public float Age { get; }
    public int Gender { get; }
    public void Attacked(float damage);
}
