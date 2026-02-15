using UnityEngine;
using UnityEngine.UI;

public class ClothingUI : MonoBehaviour
{
    [Header("Bikses (Pants)")]
    public GameObject bikses1;
    public GameObject bikses2;
    public GameObject bikses3;
    public Toggle biksesToggle;

    [Header("Zābaki (Boots)")]
    public GameObject zabaki1;
    public GameObject zabaki2;
    public GameObject zabaki3;
    public Toggle zabakiToggle;

    [Header("Cepures (Hats)")]
    public GameObject cepure1;
    public GameObject cepure2;
    public GameObject cepure3;
    public Toggle cepuresToggle;

    [Header("Cimdi (Gloves)")]
    public GameObject cimdi1;
    public GameObject cimdi2;
    public GameObject cimdi3;
    public Toggle cimdiToggle;

    [Header("Amuleti (Amulets)")]
    public GameObject amulets1;
    public GameObject amulets2;
    public GameObject amulets3;
    public Toggle amuletiToggle;

    [Header("Character Reference")]
    public GameObject character; // Tēls, uz kura liek drēbes

    // Bikšu toggle
    public void ToggleBikses(bool value)
    {
        bikses1.SetActive(value);
        bikses2.SetActive(value);
        bikses3.SetActive(value);
        Debug.Log($"Bikses: {(value ? "redzamas" : "paslēptas")}");
    }

    // Zābaku toggle
    public void ToggleZabaki(bool value)
    {
        zabaki1.SetActive(value);
        zabaki2.SetActive(value);
        zabaki3.SetActive(value);
        Debug.Log($"Zābaki: {(value ? "redzami" : "paslēpti")}");
    }

    // Cepuru toggle
    public void ToggleCepures(bool value)
    {
        cepure1.SetActive(value);
        cepure2.SetActive(value);
        cepure3.SetActive(value);
        Debug.Log($"Cepures: {(value ? "redzamas" : "paslēptas")}");
    }

    // Cimdu toggle
    public void ToggleCimdi(bool value)
    {
        cimdi1.SetActive(value);
        cimdi2.SetActive(value);
        cimdi3.SetActive(value);
        Debug.Log($"Cimdi: {(value ? "redzami" : "paslēpti")}");
    }

    // Amuletu toggle
    public void ToggleAmuleti(bool value)
    {
        amulets1.SetActive(value);
        amulets2.SetActive(value);
        amulets3.SetActive(value);
        Debug.Log($"Amuleti: {(value ? "redzami" : "paslēpti")}");
    }

    // Opcija: Paslēpt VISU
    public void HideAll()
    {
        if (biksesToggle != null) 
        {
            biksesToggle.isOn = false;
            ToggleBikses(false);
        }
        
        if (zabakiToggle != null)
        {
            zabakiToggle.isOn = false;
            ToggleZabaki(false);
        }
        
        if (cepuresToggle != null)
        {
            cepuresToggle.isOn = false;
            ToggleCepures(false);
        }
        
        if (cimdiToggle != null)
        {
            cimdiToggle.isOn = false;
            ToggleCimdi(false);
        }
        
        if (amuletiToggle != null)
        {
            amuletiToggle.isOn = false;
            ToggleAmuleti(false);
        }
    }

    // Opcija: Rādīt VISU
    public void ShowAll()
    {
        if (biksesToggle != null)
        {
            biksesToggle.isOn = true;
            ToggleBikses(true);
        }
        
        if (zabakiToggle != null)
        {
            zabakiToggle.isOn = true;
            ToggleZabaki(true);
        }
        
        if (cepuresToggle != null)
        {
            cepuresToggle.isOn = true;
            ToggleCepures(true);
        }
        
        if (cimdiToggle != null)
        {
            cimdiToggle.isOn = true;
            ToggleCimdi(true);
        }
        
        if (amuletiToggle != null)
        {
            amuletiToggle.isOn = true;
            ToggleAmuleti(true);
        }
    }
}
