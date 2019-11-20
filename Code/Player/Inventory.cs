using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Assetitem> Items;
    [SerializeField] private InventoryItemPresenter _inventoryItemPresenter;
    [SerializeField] private Transform _container;
    [SerializeField] private Transform _draggingParent;
    [SerializeField] private ItemsEjector _ejector;

    public void Start()
    {
        Render(Items);
    }

    public void PickUpItem(IItem item)
    {
        Items.Add((Assetitem)item);
    }
    public void Render(List<Assetitem> items)
    {
        foreach (Transform child in _container)
            Destroy(child.gameObject);


        items.ForEach(item =>
        {
            var cell = Instantiate(_inventoryItemPresenter, _container);
            cell.Init(_draggingParent);
            cell.Render(item);

            cell.Ejecting += () => Destroy(cell.gameObject);
            cell.Ejecting += () => _ejector.EjectFromPool(item, _ejector.transform.position, _ejector.transform.right);
        });
    }
  

}
