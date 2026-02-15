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

    [Header("Jakas (Jackets)")] // Izmainīts no Amuleti
    public GameObject jakas1;
    public GameObject jakas2;
    public GameObject jakas3;
    public Toggle jakasToggle; // Izmainīts nosaukums

    [Header("Character Reference")]
    public GameObject character;

    void Start()
    {
        // SĀKUMĀ PASLĒPT VISU!!!
        HideAllClothing();
        
        // Pārliecinās, ka toggle pogas ir "off" pozīcijā
        SetTogglesToFalse();
    }

    // Funkcija, kas paslēpj VISU apģērbu
    void HideAllClothing()
    {
        // Paslēpj bikses
        if (bikses1 != null) bikses1.SetActive(false);
        if (bikses2 != null) bikses2.SetActive(false);
        if (bikses3 != null) bikses3.SetActive(false);
        
        // Paslēpj zābakus
        if (zabaki1 != null) zabaki1.SetActive(false);
        if (zabaki2 != null) zabaki2.SetActive(false);
        if (zabaki3 != null) zabaki3.SetActive(false);
        
        // Paslēpj cepures
        if (cepure1 != null) cepure1.SetActive(false);
        if (cepure2 != null) cepure2.SetActive(false);
        if (cepure3 != null) cepure3.SetActive(false);
        
        // Paslēpj cimdus
        if (cimdi1 != null) cimdi1.SetActive(false);
        if (cimdi2 != null) cimdi2.SetActive(false);
        if (cimdi3 != null) cimdi3.SetActive(false);
        
        // Paslēpj jakas
        if (jakas1 != null) jakas1.SetActive(false);
        if (jakas2 != null) jakas2.SetActive(false);
        if (jakas3 != null) jakas3.SetActive(false);
        
        Debug.Log("Viss apģērbs paslēpts sākumā!");
    }

 // Pārliecinās, ka toggle pogas ir izslēgtas
    void SetTogglesToFalse()
    {
        if (biksesToggle != null) biksesToggle.isOn = false;
        if (zabakiToggle != null) zabakiToggle.isOn = false;
        if (cepuresToggle != null) cepuresToggle.isOn = false;
        if (cimdiToggle != null) cimdiToggle.isOn = false;
        if (jakasToggle != null) jakasToggle.isOn = false;
    }

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

    // Jaku toggle (izmainīts no Amuleti)
    public void ToggleJakas(bool value)
    {
        jakas1.SetActive(value);
        jakas2.SetActive(value);
        jakas3.SetActive(value);
        Debug.Log($"Jakas: {(value ? "redzamas" : "paslēptas")}");
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
        
        if (jakasToggle != null) // Izmainīts no amuletiToggle
        {
            jakasToggle.isOn = false;
            ToggleJakas(false);
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
        
        if (jakasToggle != null) // Izmainīts no amuletiToggle
        {
            jakasToggle.isOn = true;
            ToggleJakas(true);
        }
    }
}
