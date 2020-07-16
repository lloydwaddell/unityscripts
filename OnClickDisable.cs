using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickDisable : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        this.gameObject.SetActive(false);
    }
}
