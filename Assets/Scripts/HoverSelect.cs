using UnityEngine;
using UnityEngine.EventSystems;

public class HoverSelect : MonoBehaviour, IPointerEnterHandler,
IPointerClickHandler
{
    public int index;
    public Selector selector;


    public void OnPointerEnter(PointerEventData eventData)
    {
        selector.SetIndex(index);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        selector.ActivateItem(index);
    }
}