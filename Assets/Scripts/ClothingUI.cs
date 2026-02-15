using UnityEngine;
using UnityEngine.UI;

public class ClothingUI : MonoBehaviour
{
    // Bikses - 3 atsevišķi GameObject (kā tavā piemērā)
    public GameObject bikses1;
    public GameObject bikses2;
    public GameObject bikses3;
    public GameObject biksesToggle;  // Toggle poga kā GameObject

    // Zābaki - 3 atsevišķi GameObject
    public GameObject zabaki1;
    public GameObject zabaki2;
    public GameObject zabaki3;
    public GameObject zabakiToggle;

    // Cepures - 3 atsevišķi GameObject
    public GameObject cepure1;
    public GameObject cepure2;
    public GameObject cepure3;
    public GameObject cepuresToggle;

    // Cimdi - 3 atsevišķi GameObject
    public GameObject cimdi1;
    public GameObject cimdi2;
    public GameObject cimdi3;
    public GameObject cimdiToggle;

    // Jakas - 3 atsevišķi GameObject
    public GameObject jakas1;
    public GameObject jakas2;
    public GameObject jakas3;
    public GameObject jakasToggle;

    void Start()
    {
        // Sākumā VISU paslēpt 
        //HideAllClothing();
    }

    // Bikšu toggle - kā ToggleBean 
    public void ToggleBikses(bool val)
    {
        bikses1.SetActive(val);
        bikses2.SetActive(val);
        bikses3.SetActive(val);
        
        
    }

    // Zābaku toggle
    public void ToggleZabaki(bool val)
    {
        zabaki1.SetActive(val);
        zabaki2.SetActive(val);
        zabaki3.SetActive(val);
    }

    // Cepuru toggle
    public void ToggleCepures(bool val)
    {
        cepure1.SetActive(val);
        cepure2.SetActive(val);
        cepure3.SetActive(val);
    }

    // Cimdu toggle
    public void ToggleCimdi(bool val)
    {
        cimdi1.SetActive(val);
        cimdi2.SetActive(val);
        cimdi3.SetActive(val);
    }

    // Jaku toggle
    public void ToggleJakas(bool val)
    {
        jakas1.SetActive(val);
        jakas2.SetActive(val);
        jakas3.SetActive(val);
    }

}  
    