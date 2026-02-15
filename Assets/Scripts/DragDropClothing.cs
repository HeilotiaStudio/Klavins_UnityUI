using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropClothing : MonoBehaviour, 
    IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform trans;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    
    [Header("Drop Target")]
    public string targetTag = "Character"; // Uz kā var nolikt (tēls)
    
    [Header("Clothing Info")]
    public string clothingType = "bikses"; // bikses, jakas, utt.
    public int clothingIndex = 1; // 1,2,3
    
    // Sākotnējā pozīcija (ja grib atcelt)
    private Vector2 originalPosition;
    private Transform originalParent;
    
    void Start()
    {
        trans = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        
        // Pievieno CanvasGroup ja nav
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        
        // Atcerēties sākotnējo pozīciju
        originalPosition = trans.anchoredPosition;
        originalParent = transform.parent;
        
        Debug.Log($"DragDropClothing start: {clothingType} {clothingIndex}");
    }

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log($"🖱️ Klikšķis uz {clothingType} {clothingIndex}");
        
        // Atskaņo skaņu (ja ir)
        // sfxScript.PlaySFX(0);
        
        // Paceļ objektu virs citiem
        transform.SetAsLastSibling();
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log($"👉 Sāk vilkt {clothingType} {clothingIndex}");
        
        // Padara objektu caurspīdīgāku velkot
        canvasGroup.alpha = 0.8f;
        
        // Ļauj tam iet cauri raycast (lai var nolaist uz tēla)
        canvasGroup.blocksRaycasts = false;
        
        // Atskaņo skaņu
        // sfxScript.PlaySFX(1);
    }

    public void OnDrag(PointerEventData data)
    {
        // Pārvieto objektu peles pozīcijā
        trans.anchoredPosition += data.delta / canvas.scaleFactor;
        
        // IEROBEŽOJUMS: Paliek ekrānā
        Vector2 clampedPos = trans.anchoredPosition;
        
        // Pievieno robežas ja vajag
        // clampedPos.x = Mathf.Clamp(clampedPos.x, minX, maxX);
        // clampedPos.y = Mathf.Clamp(clampedPos.y, minY, maxY);
        
        trans.anchoredPosition = clampedPos;
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log($"✅ Beidz vilkt {clothingType} {clothingIndex}");
        
        // Atjauno normālu izskatu
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        
        // Pārbauda vai nolaists uz tēla
        GameObject droppedOn = data.pointerEnter;
        
        if (droppedOn != null && droppedOn.CompareTag(targetTag))
        {
            // NOLAISTS UZ TĒLA!
            Debug.Log($"🎯 {clothingType} {clothingIndex} nolaists uz tēla!");
            
            // Pievienojies tēlam kā bērns
            transform.SetParent(droppedOn.transform);
            
            // Atskaņo veiksmes skaņu
            // sfxScript.PlaySFX(2);
            
            // Iespējams, pozicionē uz konkrētu vietu
            // trans.anchoredPosition = new Vector2(0, 0); // Atkarīgs no tava layout
        }
        else
        {
            // NOLAISTS ĀRPUS TĒLA - atgriežas atpakaļ
            Debug.Log($"❌ {clothingType} {clothingIndex} nolaists ārpus tēla - atgriežas");
            
            transform.SetParent(originalParent);
            trans.anchoredPosition = originalPosition;
            
            // Atskaņo kļūdas skaņu
            // sfxScript.PlaySFX(3);
        }
    }
    
    // Lai atiestatītu uz sākotnējo pozīciju
    public void ResetPosition()
    {
        transform.SetParent(originalParent);
        trans.anchoredPosition = originalPosition;
    }
}
