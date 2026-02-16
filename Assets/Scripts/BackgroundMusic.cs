using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [Header("Music Settings")]
    [SerializeField] private SFXScript sfxScript; // Tas pats skripts!
    [SerializeField] private int musicClipIndex = 3; // 3 = background sound
    [SerializeField] private bool playOnStart = true;
    [SerializeField] private bool enableMusic = true;
    
    void Start()
    {
        if (!enableMusic) return;
        
        // Mēģina atrast SFXScript ja nav norādīts
        if (sfxScript == null)
            sfxScript = FindFirstObjectByType<SFXScript>();
        
        if (sfxScript == null)
        {
            Debug.LogError("Nav SFXScript! Fona mūzika neatskaņosies.");
            return;
        }
        
        if (playOnStart)
        {
            PlayBackgroundMusic();
        }
    }
    
    public void PlayBackgroundMusic()
    {
        if (sfxScript != null)
        {
            // IZMANTOT PLAYMUSIC, NEVIS PLAYSOUND!
            sfxScript.PlayMusic(musicClipIndex);
            Debug.Log($"Fona mūzika atskaņojas! Klips {musicClipIndex}");
        }
    }
    
    // Ja gribi apturēt
    public void StopBackgroundMusic()
    {
        if (sfxScript != null)
        {
            sfxScript.StopMusic(); // Izmanto jauno StopMusic funkciju!
        }
    }
}
