using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource sFXSource;      // Skaņu efektiem (velc šeit pirmo)
    public AudioSource musicSource;     // Fona mūzikai (velc šeit OTRO!)
    public AudioClip[] audioClip;

    public void PlaySFX(int ix) 
    {
        // Skaņas efekts - NEAPSTĀDINA fona mūziku!
        sFXSource.PlayOneShot(audioClip[ix]);
        Debug.Log($"Spēlē skaņu {ix}");
    }

    public void PlayMusic(int ix) 
    {
        // Fona mūzika - spēlē caur citu AudioSource
        if (musicSource != null && !musicSource.isPlaying)
        {
            musicSource.clip = audioClip[ix];
            musicSource.loop = true;      // Fona mūzika atkārtojas
            musicSource.Play();
            Debug.Log($"Fona mūzika starts ar {ix}");
        }
    }

    public void StopMusic() 
    {
        if (musicSource != null)
            musicSource.Stop();
    }
}
