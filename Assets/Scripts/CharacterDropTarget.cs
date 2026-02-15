using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterDropTarget : MonoBehaviour, IDropHandler
{
    [Header("Clothing Spots")]
    public Transform biksesSpot;    // Kur jānoliek bikses
    public Transform jakasSpot;      // Kur jānoliek jakas
    // ... pievieno citus
    
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log($"🎯 Kaut kas nomests uz tēla!");
        
        // Pārbauda vai nomestais ir drēbes
        DragDropClothing draggedClothing = eventData.pointerDrag.GetComponent<DragDropClothing>();
        
        if (draggedClothing != null)
        {
            Debug.Log($"   Nomests: {draggedClothing.clothingType} {draggedClothing.clothingIndex}");
            
            // Nosaka kur nolikt atkarībā no tipa
            Transform targetSpot = null;
            
            switch (draggedClothing.clothingType)
            {
                case "bikses":
                    targetSpot = biksesSpot;
                    break;
                case "jakas":
                    targetSpot = jakasSpot;
                    break;
                // pievieno citus tipus
            }
            
            if (targetSpot != null)
            {
                // Pievieno konkrētajai vietai
                draggedClothing.transform.SetParent(targetSpot);
                draggedClothing.transform.localPosition = Vector3.zero;
                Debug.Log($"   Pievienots pie {targetSpot.name}");
            }
        }
    }
}
