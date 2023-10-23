public interface Item_Container
{
    int ItemCount(Item item);
    bool ContainsItems(Item item); 
    bool RemovingItems(Item item);
    bool AddItems(Item item);
    bool IsFull();



}